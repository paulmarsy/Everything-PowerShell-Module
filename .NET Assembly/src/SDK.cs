using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Voidtools.Everything
{
	public class SDK
	{
		public const int EVERYTHING_OK                      = 0;
		public const int EVERYTHING_ERROR_MEMORY            = 1;
		public const int EVERYTHING_ERROR_IPC               = 2;
		public const int EVERYTHING_ERROR_REGISTERCLASSEX   = 3;
		public const int EVERYTHING_ERROR_CREATEWINDOW      = 4;
		public const int EVERYTHING_ERROR_CREATETHREAD      = 5;
		public const int EVERYTHING_ERROR_INVALIDINDEX      = 6;
		public const int EVERYTHING_ERROR_INVALIDCALL       = 7;

		// write search state
		[DllImport("Everything", EntryPoint = "Everything_SetSearchW", CharSet = CharSet.Unicode)]
		public static extern void Everything_SetSearchW(string lpString);
		[DllImport("Everything", EntryPoint = "Everything_SetMatchPath")]
		public static extern void Everything_SetMatchPath(bool bEnable);
		[DllImport("Everything", EntryPoint = "Everything_SetMatchCase")]
		public static extern void Everything_SetMatchCase(bool bEnable);
		[DllImport("Everything", EntryPoint = "Everything_SetMatchWholeWord")]
		public static extern void Everything_SetMatchWholeWord(bool bEnable);
		[DllImport("Everything", EntryPoint = "Everything_SetRegex")]
		public static extern void Everything_SetRegex(bool bEnable);
		[DllImport("Everything", EntryPoint = "Everything_SetMax")]
		public static extern void Everything_SetMax(UInt32 dwMax);
		[DllImport("Everything", EntryPoint = "Everything_SetOffset")]
		public static extern void Everything_SetOffset(UInt32 dwOffset);
		[DllImport("Everything", EntryPoint = "Everything_SetReplyWindow")]
		public static extern void Everything_SetReplyWindow(IntPtr hWnd);
		[DllImport("Everything", EntryPoint = "Everything_SetReplyID")]
		public static extern void Everything_SetReplyID(UInt32 nId);
		
		// read search state
		[DllImport("Everything", EntryPoint = "Everything_GetMatchPath")]
		public static extern bool Everything_GetMatchPath();
		[DllImport("Everything", EntryPoint = "Everything_GetMatchCase")]
		public static extern bool Everything_GetMatchCase();
		[DllImport("Everything", EntryPoint = "Everything_GetMatchWholeWord")]
		public static extern bool Everything_GetMatchWholeWord();
		[DllImport("Everything", EntryPoint = "Everything_GetRegex")]
		public static extern bool Everything_GetRegex();
		[DllImport("Everything", EntryPoint = "Everything_GetMax")]
		public static extern UInt32 Everything_GetMax();
		[DllImport("Everything", EntryPoint = "Everything_GetOffset")]
		public static extern UInt32 Everything_GetOffset();
		[DllImport("Everything", EntryPoint = "Everything_GetSearchW", CharSet = CharSet.Unicode)]
		public static extern string Everything_GetSearchW();
		[DllImport("Everything", EntryPoint = "Everything_GetLastError")]
		public static extern UInt32 Everything_GetLastError();
		[DllImport("Everything", EntryPoint = "Everything_GetReplyWindow")]
		public static extern IntPtr Everything_GetReplyWindow();
		[DllImport("Everything", EntryPoint = "Everything_GetReplyID")]
		public static extern UInt32 Everything_GetReplyID();

		// execute query
		[DllImport("Everything", EntryPoint = "Everything_QueryW")]
		public static extern bool Everything_QueryW(bool bWait);

		// query reply
		[DllImport("Everything", EntryPoint = "Everything_IsQueryReply")]
		public static extern bool Everything_IsQueryReply(uint message, UIntPtr wParam, IntPtr lParam, UInt32 nId);

		// write result state
		[DllImport("Everything", EntryPoint = "Everything_SortResultsByPath")]
		public static extern void Everything_SortResultsByPath();

		// read result state
		[DllImport("Everything", EntryPoint = "Everything_GetNumFileResults")]
		public static extern UInt32 Everything_GetNumFileResults();
		[DllImport("Everything", EntryPoint = "Everything_GetNumFolderResults")]
		public static extern UInt32 Everything_GetNumFolderResults();
		[DllImport("Everything", EntryPoint = "Everything_GetNumResults")]
		public static extern UInt32 Everything_GetNumResults();
		[DllImport("Everything", EntryPoint = "Everything_GetTotFileResults")]
		public static extern UInt32 Everything_GetTotFileResults();
		[DllImport("Everything", EntryPoint = "Everything_GetTotFolderResults")]
		public static extern UInt32 Everything_GetTotFolderResults();
		[DllImport("Everything", EntryPoint = "Everything_GetTotResults")]
		public static extern UInt32 Everything_GetTotResults();
		[DllImport("Everything", EntryPoint = "Everything_IsVolumeResult")]
		public static extern bool Everything_IsVolumeResult(UInt32 nIndex);
		[DllImport("Everything", EntryPoint = "Everything_IsFolderResult")]
		public static extern bool Everything_IsFolderResult(UInt32 nIndex);
		[DllImport("Everything", EntryPoint = "Everything_IsFileResult")]
		public static extern bool Everything_IsFileResult(UInt32 nIndex);
		[DllImport("Everything", EntryPoint = "Everything_GetResultFileNameW", CharSet = CharSet.Unicode)]
		public static extern string Everything_GetResultFileNameW(UInt32 nIndex);
		[DllImport("Everything", EntryPoint = "Everything_GetResultPathW", CharSet = CharSet.Unicode)]
		public static extern string Everything_GetResultPathW(UInt32 nIndex);
		[DllImport("Everything", EntryPoint = "Everything_GetResultFullPathNameW", CharSet = CharSet.Unicode)]
		public static extern UInt32 Everything_GetResultFullPathNameW(UInt32 nIndex, StringBuilder wbuf, UInt32 wbuf_size_in_wchars);
		
		// reset state and free any allocated memory
		[DllImport("Everything", EntryPoint = "Everything_Reset")]
		public static extern void Everything_Reset();
	}
}