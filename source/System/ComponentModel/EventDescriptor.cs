using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000373")]
	public abstract class EventDescriptor : MemberDescriptor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001708")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC14", Offset = "0x1E4AC14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		protected EventDescriptor(string name, Attribute[] attrs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001709")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC1C", Offset = "0x1E4AC1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
		protected EventDescriptor(MemberDescriptor descr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600170A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4AC24", Offset = "0x1E4AC24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		protected EventDescriptor(MemberDescriptor descr, Attribute[] attrs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700053A")]
		public abstract Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700053B")]
		public abstract Type EventType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700053C")]
		public abstract bool IsMulticast
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600170E")]
		public abstract void AddEventHandler(object component, Delegate value);

		[global::Cpp2ILInjected.Token(Token = "0x600170F")]
		public abstract void RemoveEventHandler(object component, Delegate value);
	}
}
