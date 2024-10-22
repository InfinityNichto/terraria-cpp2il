﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000040")]
	public class Logger : ILogger, ILogHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C3FC", Offset = "0x1F6C3FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Logger(ILogHandler logHandler)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public ILogHandler logHandler
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C674", Offset = "0x1F6C674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000085")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C67C", Offset = "0x1F6C67C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public bool logEnabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C684", Offset = "0x1F6C684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C68C", Offset = "0x1F6C68C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public LogType filterLogType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C698", Offset = "0x1F6C698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6C6A0", Offset = "0x1F6C6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C6A8", Offset = "0x1F6C6A8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsLogTypeAllowed(LogType logType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C6E4", Offset = "0x1F6C6E4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Logger), Member = "Log", MemberParameters = new object[]
		{
			typeof(LogType),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Logger), Member = "Log", MemberParameters = new object[]
		{
			typeof(LogType),
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Logger), Member = "LogError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string GetString(object message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C804", Offset = "0x1F6C804", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "GetString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Log(LogType logType, object message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C960", Offset = "0x1F6C960", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "GetString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Log(LogType logType, object message, Object context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6CAC0", Offset = "0x1F6CAC0", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "GetString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void LogError(string tag, object message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6CC2C", Offset = "0x1F6CC2C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void LogException(Exception exception, Object context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6CCF8", Offset = "0x1F6CCF8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			throw null;
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ILogHandler <logHandler>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <logEnabled>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private LogType <filterLogType>k__BackingField;
	}
}
