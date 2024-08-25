using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.MonoTODO("Serialized objects are not compatible with MS.NET")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005D3")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class StackFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04B48", Offset = "0x1C04B48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool get_frame_info(int skip, bool needFileInfo, out global::System.Reflection.MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column);

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

		[global::Cpp2ILInjected.Token(Token = "0x6002D60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04C00", Offset = "0x1C04C00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int GetFileLineNumber()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04C08", Offset = "0x1C04C08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual string GetFileName()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002D63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CE4", Offset = "0x1C04CE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int GetILOffset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CEC", Offset = "0x1C04CEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual global::System.Reflection.MethodBase GetMethod()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CF4", Offset = "0x1C04CF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int GetNativeOffset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04CFC", Offset = "0x1C04CFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal long GetMethodAddress()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04D04", Offset = "0x1C04D04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal uint GetMethodIndex()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04D0C", Offset = "0x1C04D0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string GetInternalMethodName()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001960")]
		public const int OFFSET_UNKNOWN = -1;

		[global::Cpp2ILInjected.Token(Token = "0x4001961")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int ilOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4001962")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int nativeOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4001963")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long methodAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4001964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private uint methodIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4001965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Reflection.MethodBase methodBase;

		[global::Cpp2ILInjected.Token(Token = "0x4001966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string fileName;

		[global::Cpp2ILInjected.Token(Token = "0x4001967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int lineNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4001968")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int columnNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4001969")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string internalMethodName;
	}
}
