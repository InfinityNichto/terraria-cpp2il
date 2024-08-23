using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200015F RID: 351
	[global::Cpp2ILInjected.Token(Token = "0x20001F3")]
	internal static class GlobalLog
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x00004D9F File Offset: 0x00002F9F
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CC4", Offset = "0x1F26CC4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalLog), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static BaseLoggingObject LoggingInitialize()
		{
			throw null;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00004DA2 File Offset: 0x00002FA2
		[global::Cpp2ILInjected.Token(Token = "0x17000285")]
		internal static ThreadKinds CurrentThreadKind
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F26D18", Offset = "0x1F26D18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00004DA5 File Offset: 0x00002FA5
		[Conditional("DEBUG")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26D20", Offset = "0x1F26D20", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void SetThreadSource(ThreadKinds source)
		{
			throw null;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00004DA8 File Offset: 0x00002FA8
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26D24", Offset = "0x1F26D24", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void ThreadContract(ThreadKinds kind, string errorMsg)
		{
			throw null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00004DAB File Offset: 0x00002FAB
		[Conditional("DEBUG")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26D28", Offset = "0x1F26D28", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void ThreadContract(ThreadKinds kind, ThreadKinds allowedSources, string errorMsg)
		{
			throw null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00004DAE File Offset: 0x00002FAE
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DCC", Offset = "0x1F26DCC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void AddToArray(string msg)
		{
			throw null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00004DB1 File Offset: 0x00002FB1
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DD0", Offset = "0x1F26DD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Ignore(object msg)
		{
			throw null;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DD4", Offset = "0x1F26DD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Print(string msg)
		{
			throw null;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00004DB7 File Offset: 0x00002FB7
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DD8", Offset = "0x1F26DD8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void PrintHex(string msg, object value)
		{
			throw null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00004DBA File Offset: 0x00002FBA
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DDC", Offset = "0x1F26DDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Enter(string func)
		{
			throw null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00004DBD File Offset: 0x00002FBD
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DE0", Offset = "0x1F26DE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Enter(string func, string parms)
		{
			throw null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00004DC0 File Offset: 0x00002FC0
		[Conditional("DEBUG")]
		[Conditional("_FORCE_ASSERTS")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26DE4", Offset = "0x1F26DE4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Assert(bool condition, string messageFormat, params object[] data)
		{
			throw null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00004DC3 File Offset: 0x00002FC3
		[Conditional("_FORCE_ASSERTS")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[Conditional("DEBUG")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26E7C", Offset = "0x1F26E7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Assert(string message)
		{
			throw null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00004DC6 File Offset: 0x00002FC6
		[Conditional("DEBUG")]
		[Conditional("_FORCE_ASSERTS")]
		[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.None)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26E80", Offset = "0x1F26E80", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void Assert(string message, string detailMessage)
		{
			throw null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00004DC9 File Offset: 0x00002FC9
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F74", Offset = "0x1F26F74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void LeaveException(string func, Exception exception)
		{
			throw null;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F78", Offset = "0x1F26F78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Leave(string func)
		{
			throw null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00004DCF File Offset: 0x00002FCF
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F7C", Offset = "0x1F26F7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Leave(string func, string result)
		{
			throw null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00004DD2 File Offset: 0x00002FD2
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F80", Offset = "0x1F26F80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Leave(string func, int returnval)
		{
			throw null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00004DD5 File Offset: 0x00002FD5
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F84", Offset = "0x1F26F84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Leave(string func, bool returnval)
		{
			throw null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00004DD8 File Offset: 0x00002FD8
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F88", Offset = "0x1F26F88", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DumpArray()
		{
			throw null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00004DDB File Offset: 0x00002FDB
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F8C", Offset = "0x1F26F8C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dump(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00004DDE File Offset: 0x00002FDE
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F90", Offset = "0x1F26F90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dump(byte[] buffer, int length)
		{
			throw null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00004DE1 File Offset: 0x00002FE1
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F94", Offset = "0x1F26F94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dump(byte[] buffer, int offset, int length)
		{
			throw null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Conditional("TRAVE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000C55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F98", Offset = "0x1F26F98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dump(IntPtr buffer, int offset, int length)
		{
			throw null;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00004DE7 File Offset: 0x00002FE7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000C56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26F9C", Offset = "0x1F26F9C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlobalLog), Member = "LoggingInitialize", ReturnType = typeof(BaseLoggingObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static GlobalLog()
		{
			throw null;
		}

		// Token: 0x0400085B RID: 2139
		[global::Cpp2ILInjected.Token(Token = "0x4000AA0")]
		private static BaseLoggingObject Logobject;
	}
}
