using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace GhostHearth
{
	class HSWindowManager
	{
		[DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string className, string windowName);

		[DllImport("user32.dll")]
		public static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int X, int Y, int cx, int cy, uint flags);
		private const int HWND_NOTOPMOST = -2;
		private const int HWND_TOPMOST = -1;
		private const int SWP_NOSIZE = 0x1;
		private const int SWP_NOMOVE = 0x2;

		[DllImport("user32.dll")]
		private static extern long GetWindowLong(IntPtr hwnd, int nIndex);
		private const int GWL_EXSTYLE = -20;

		[DllImport("user32.dll")]
		private static extern bool SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);
		private const int WS_EX_LAYERED = 0x80000;

		[DllImport("user32.dll")]
		private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, int crKey, byte alpha, uint dwFlags);
		private const int LWA_COLORKEY = 0x1;
		private const int LWA_ALPHA = 0x2;

		// position := 0 to unfloat, 1 to unfloat
		public static string FloatHS(int position)
		{
			IntPtr hwnd = FindWindow(null, "Hearthstone");

			if (hwnd == IntPtr.Zero)
			{
				return "Failed to find instance of Hearthstone";
			}

			IntPtr positionFlag = (IntPtr)((position == 0) ? (HWND_NOTOPMOST) : (HWND_TOPMOST));
			string positionString = (position == 0) ? ("Unfloat") : ("Float");

			if (!SetWindowPos(hwnd, positionFlag, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE))
			{
				return String.Format("Failed to {0} Hearthstone window", positionString);
			}

			return String.Format("{0}ed Hearthstone window", positionString);
		}

		public static string SetHSAlpha(int amount)
		{
			IntPtr hwnd = FindWindow(null, "Hearthstone");

			if (hwnd == IntPtr.Zero)
			{
				return "Failed to find instance of Hearthstone";
			}

			byte scaledAmount = (byte)(255 * ((double)amount / 10));

			long exstyle = GetWindowLong(hwnd, GWL_EXSTYLE);

			if (!SetWindowLong(hwnd, GWL_EXSTYLE, exstyle | WS_EX_LAYERED))
			{
				return "Failed to set window long";
			}

			if (!SetLayeredWindowAttributes(hwnd, 0, scaledAmount, LWA_ALPHA))
			{
				return "Failed to set attribute";
			}

			return String.Format("Successfully set Hearthstone alpha to {0}0%", amount);
		}
	}
}
