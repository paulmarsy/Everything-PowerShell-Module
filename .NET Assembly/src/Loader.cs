using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Voidtools.Everything
{
	public static class Loader
	{
		private static IntPtr LibraryHandle;
		
		[DllImport("kernel32.dll", SetLastError=true)]
		private static extern IntPtr LoadLibrary(string lpFileName);
		
		public static void LoadNativeDll()
		{
			var rootPath = Path.GetDirectoryName(Assembly.GetAssembly(typeof(Loader)).Location);

			var everythingSdkPath = Path.Combine(rootPath, Environment.Is64BitProcess ? "x64" : "x86", "Everything.dll");
			
			if (!File.Exists(everythingSdkPath))
				throw new FileNotFoundException("Unable to find native Everything DLL", everythingSdkPath);

			LibraryHandle = LoadLibrary(everythingSdkPath);

			if (LibraryHandle == null || LibraryHandle == IntPtr.Zero)
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
	}
}
