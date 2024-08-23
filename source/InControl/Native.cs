using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000038 RID: 56
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	internal static class Native
	{
		// Token: 0x06000320 RID: 800 RVA: 0x000029AB File Offset: 0x00000BAB
		[global::Cpp2ILInjected.Token(Token = "0x6000324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998C1C", Offset = "0x1998C1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Init(NativeInputOptions options)
		{
			throw null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000029AE File Offset: 0x00000BAE
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998C20", Offset = "0x1998C20", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Stop()
		{
			throw null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000029B1 File Offset: 0x00000BB1
		[global::Cpp2ILInjected.Token(Token = "0x6000326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998C24", Offset = "0x1998C24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void GetVersionInfo(out NativeVersionInfo versionInfo)
		{
			throw null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000029B4 File Offset: 0x00000BB4
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998C2C", Offset = "0x1998C2C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool GetDeviceInfo(uint handle, out InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000029B7 File Offset: 0x00000BB7
		[global::Cpp2ILInjected.Token(Token = "0x6000328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998C40", Offset = "0x1998C40", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool GetDeviceState(uint handle, out IntPtr deviceState)
		{
			throw null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000029BA File Offset: 0x00000BBA
		[global::Cpp2ILInjected.Token(Token = "0x6000329")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998C94", Offset = "0x1998C94", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int GetDeviceEvents(out IntPtr deviceEvents)
		{
			throw null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000029BD File Offset: 0x00000BBD
		[global::Cpp2ILInjected.Token(Token = "0x600032A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998CE8", Offset = "0x1998CE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetHapticState(uint handle, byte motor0, byte motor1)
		{
			throw null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000029C0 File Offset: 0x00000BC0
		[global::Cpp2ILInjected.Token(Token = "0x600032B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998CEC", Offset = "0x1998CEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetLightColor(uint handle, byte red, byte green, byte blue)
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000029C3 File Offset: 0x00000BC3
		[global::Cpp2ILInjected.Token(Token = "0x600032C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1998CF0", Offset = "0x1998CF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetLightFlash(uint handle, byte flashOnDuration, byte flashOffDuration)
		{
			throw null;
		}

		// Token: 0x040002C1 RID: 705
		[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
		private const string libraryName = "InControlNative";
	}
}
