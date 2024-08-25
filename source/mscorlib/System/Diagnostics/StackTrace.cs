using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.MonoTODO("Serialized objects are not compatible with .NET")]
	[global::Cpp2ILInjected.Token(Token = "0x20005D4")]
	[global::System.Serializable]
	public class StackTrace
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04F44", Offset = "0x1C04F44", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[MethodImpl(8)]
		public StackTrace()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0515C", Offset = "0x1C0515C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[MethodImpl(8)]
		public StackTrace(bool fNeedFileInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0518C", Offset = "0x1C0518C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "get_StackTrace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStackTrace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStringFromExceptionInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[MethodImpl(8)]
		public StackTrace(int skipFrames, bool fNeedFileInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04F68", Offset = "0x1C04F68", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Thread),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		[MethodImpl(8)]
		private void init_frames(int skipFrames, bool fNeedFileInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C051C0", Offset = "0x1C051C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern StackFrame[] get_trace(global::System.Exception e, int skipFrames, bool fNeedFileInfo);

		[global::Cpp2ILInjected.Token(Token = "0x6002D6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C051C8", Offset = "0x1C051C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "get_Source", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public StackTrace(global::System.Exception e, bool fNeedFileInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C051D4", Offset = "0x1C051D4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public StackTrace(global::System.Exception e, int skipFrames, bool fNeedFileInfo)
		{
			throw null;
		}

		[global::System.MonoLimitation("Not possible to create StackTraces from other threads")]
		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x6002D71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C052BC", Offset = "0x1C052BC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ThreadedRenderManager", Member = "GetStackTrace", MemberParameters = new object[] { typeof(global::System.Threading.Thread) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public StackTrace(global::System.Threading.Thread targetThread, bool needFileInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170006E8")]
		public virtual int FrameCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C05334", Offset = "0x1C05334", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0534C", Offset = "0x1C0534C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual StackFrame GetFrame(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C05394", Offset = "0x1C05394", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetAotId", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static string GetAotId()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0545C", Offset = "0x1C0545C", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(global::System.Reflection.MethodBase),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackFrame), Member = "GetSecureFileName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private bool AddFrames(global::System.Text.StringBuilder sb, bool separator, out bool isAsync)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C058AC", Offset = "0x1C058AC", Length = "0x5B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeExtensions), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "ConvertAsyncStateMachineMethod", MemberParameters = new object[]
		{
			typeof(ref global::System.Reflection.MethodBase),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void GetFullNameForStackTrace(global::System.Text.StringBuilder sb, global::System.Reflection.MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C05E5C", Offset = "0x1C05E5C", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(global::System.Reflection.MethodBase),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void ConvertAsyncStateMachineMethod(ref global::System.Reflection.MethodBase method, ref global::System.Type declaringType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06270", Offset = "0x1C06270", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C063B4", Offset = "0x1C063B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string ToString(StackTrace.TraceFormat traceFormat)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400196A")]
		public const int METHODS_TO_SKIP = 0;

		[global::Cpp2ILInjected.Token(Token = "0x400196B")]
		private const string prefix = "  at ";

		[global::Cpp2ILInjected.Token(Token = "0x400196C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private StackFrame[] frames;

		[global::Cpp2ILInjected.Token(Token = "0x400196D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly StackTrace[] captured_traces;

		[global::Cpp2ILInjected.Token(Token = "0x400196E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool debug_info;

		[global::Cpp2ILInjected.Token(Token = "0x400196F")]
		private static bool isAotidSet;

		[global::Cpp2ILInjected.Token(Token = "0x4001970")]
		private static string aotid;

		[global::Cpp2ILInjected.Token(Token = "0x20005D5")]
		internal enum TraceFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001972")]
			Normal,
			[global::Cpp2ILInjected.Token(Token = "0x4001973")]
			TrailingNewLine,
			[global::Cpp2ILInjected.Token(Token = "0x4001974")]
			NoResourceLookup
		}
	}
}
