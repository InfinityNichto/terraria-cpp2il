﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003B4")]
	public class RefreshEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x600194E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D258", Offset = "0x1E5D258", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RefreshEventArgs(object componentChanged)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D2D4", Offset = "0x1E5D2D4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RefreshEventArgs(Type typeChanged)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005CB")]
		public object ComponentChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001950")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D340", Offset = "0x1E5D340", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005CC")]
		public Type TypeChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001951")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D348", Offset = "0x1E5D348", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly object <ComponentChanged>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Type <TypeChanged>k__BackingField;
	}
}
