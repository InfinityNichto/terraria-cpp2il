using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F1")]
	internal class BaseLoggingObject
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26C88", Offset = "0x1F26C88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BaseLoggingObject()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26C90", Offset = "0x1F26C90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void EnterFunc(string funcname)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26C94", Offset = "0x1F26C94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void LeaveFunc(string funcname)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26C98", Offset = "0x1F26C98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void DumpArrayToConsole()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26C9C", Offset = "0x1F26C9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void PrintLine(string msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CA0", Offset = "0x1F26CA0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void DumpArray(bool shouldClose)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CA4", Offset = "0x1F26CA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void DumpArrayToFile(bool shouldClose)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CA8", Offset = "0x1F26CA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Flush()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CAC", Offset = "0x1F26CAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Flush(bool close)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CB0", Offset = "0x1F26CB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void LoggingMonitorTick()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CB4", Offset = "0x1F26CB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Dump(byte[] buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CB8", Offset = "0x1F26CB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Dump(byte[] buffer, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CBC", Offset = "0x1F26CBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Dump(byte[] buffer, int offset, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26CC0", Offset = "0x1F26CC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Dump(IntPtr pBuffer, int offset, int length)
		{
			throw null;
		}
	}
}
