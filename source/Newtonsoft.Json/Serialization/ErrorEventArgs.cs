﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000085")]
	public class ErrorEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public object CurrentObject
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3738", Offset = "0x1CE3738", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3740", Offset = "0x1CE3740", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public ErrorContext ErrorContext
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3748", Offset = "0x1CE3748", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3750", Offset = "0x1CE3750", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3758", Offset = "0x1CE3758", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object <CurrentObject>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ErrorContext <ErrorContext>k__BackingField;
	}
}
