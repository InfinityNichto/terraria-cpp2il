using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x020004E1 RID: 1249
	[global::System.MonoTODO("Serialized objects are not compatible with MS.NET")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D3")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class StackFrame
	{
		// Token: 0x060029FC RID: 10748
		[global::Cpp2ILInjected.Token(Token = "0x6002D5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04B48", Offset = "0x1C04B48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool get_frame_info(int skip, bool needFileInfo, out global::System.Reflection.MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column);

		// Token: 0x060029FD RID: 10749 RVA: 0x0001BA34 File Offset: 0x00019C34
		[global::Cpp2ILInjected.Token(Token = "0x6002D5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04B50", Offset = "0x1C04B50", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public StackFrame()
		{
			throw null;
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0001BA37 File Offset: 0x00019C37
		[global::Cpp2ILInjected.Token(Token = "0x6002D5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04BA0", Offset = "0x1C04BA0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(8)]
		public StackFrame(int skipFrames, bool fNeedFileInfo)
		{
			throw null;
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0001BA3A File Offset: 0x00019C3A
		[global::Cpp2ILInjected.Token(Token = "0x6002D60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04C00", Offset = "0x1C04C00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int GetFileLineNumber()
		{
			throw null;
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x0001BA3D File Offset: 0x00019C3D
		[global::Cpp2ILInjected.Token(Token = "0x6002D61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04C08", Offset = "0x1C04C08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual string GetFileName()
		{
			throw null;
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0001BA40 File Offset: 0x00019C40
		[global::Cpp2ILInjected.Token(Token = "0x6002D62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04C10", Offset = "0x1C04C10", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackFrame), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal string GetSecureFileName()
		{
			throw null;
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0001BA43 File Offset: 0x00019C43
		[global::Cpp2ILInjected.Token(Token = "0x6002D63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CE4", Offset = "0x1C04CE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int GetILOffset()
		{
			throw null;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0001BA46 File Offset: 0x00019C46
		[global::Cpp2ILInjected.Token(Token = "0x6002D64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CEC", Offset = "0x1C04CEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual global::System.Reflection.MethodBase GetMethod()
		{
			throw null;
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x0001BA49 File Offset: 0x00019C49
		[global::Cpp2ILInjected.Token(Token = "0x6002D65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CF4", Offset = "0x1C04CF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int GetNativeOffset()
		{
			throw null;
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x0001BA4C File Offset: 0x00019C4C
		[global::Cpp2ILInjected.Token(Token = "0x6002D66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CFC", Offset = "0x1C04CFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal long GetMethodAddress()
		{
			throw null;
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x0001BA4F File Offset: 0x00019C4F
		[global::Cpp2ILInjected.Token(Token = "0x6002D67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04D04", Offset = "0x1C04D04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal uint GetMethodIndex()
		{
			throw null;
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x0001BA52 File Offset: 0x00019C52
		[global::Cpp2ILInjected.Token(Token = "0x6002D68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04D0C", Offset = "0x1C04D0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string GetInternalMethodName()
		{
			throw null;
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x0001BA55 File Offset: 0x00019C55
		[global::Cpp2ILInjected.Token(Token = "0x6002D69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04D14", Offset = "0x1C04D14", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackFrame), Member = "GetSecureFileName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001577 RID: 5495
		[global::Cpp2ILInjected.Token(Token = "0x4001960")]
		public const int OFFSET_UNKNOWN = -1;

		// Token: 0x04001578 RID: 5496
		[global::Cpp2ILInjected.Token(Token = "0x4001961")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int ilOffset;

		// Token: 0x04001579 RID: 5497
		[global::Cpp2ILInjected.Token(Token = "0x4001962")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int nativeOffset;

		// Token: 0x0400157A RID: 5498
		[global::Cpp2ILInjected.Token(Token = "0x4001963")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long methodAddress;

		// Token: 0x0400157B RID: 5499
		[global::Cpp2ILInjected.Token(Token = "0x4001964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private uint methodIndex;

		// Token: 0x0400157C RID: 5500
		[global::Cpp2ILInjected.Token(Token = "0x4001965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Reflection.MethodBase methodBase;

		// Token: 0x0400157D RID: 5501
		[global::Cpp2ILInjected.Token(Token = "0x4001966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string fileName;

		// Token: 0x0400157E RID: 5502
		[global::Cpp2ILInjected.Token(Token = "0x4001967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int lineNumber;

		// Token: 0x0400157F RID: 5503
		[global::Cpp2ILInjected.Token(Token = "0x4001968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int columnNumber;

		// Token: 0x04001580 RID: 5504
		[global::Cpp2ILInjected.Token(Token = "0x4001969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string internalMethodName;
	}
}
