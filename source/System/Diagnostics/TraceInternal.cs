using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
	internal static class TraceInternal
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public static TraceListenerCollection Listeners
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC52F8", Offset = "0x1EC52F8", Length = "0x230")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultTraceListener), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListener), Member = "set_IndentSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceListenerCollection), Member = "Add", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public static bool AutoFlush
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5574", Offset = "0x1EC5574", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public static int IndentLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5F80", Offset = "0x1EC5F80", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public static int IndentSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC5FD8", Offset = "0x1EC5FD8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceListenerCollection), Member = "InitializeListener", MemberParameters = new object[] { typeof(TraceListener) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5CD0", Offset = "0x1EC5CD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void InitializeSettings()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC6038", Offset = "0x1EC6038", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static TraceInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
		private static string appName;

		[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
		private static TraceListenerCollection listeners;

		[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
		private static bool autoFlush;

		[ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
		private static int indentLevel;

		[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
		private static int indentSize;

		[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
		internal static readonly object critSec;
	}
}
