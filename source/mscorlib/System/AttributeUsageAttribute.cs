using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200008E")]
	[global::System.Serializable]
	public sealed class AttributeUsageAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000406")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB65D4", Offset = "0x1BB65D4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AttributeUsageAttribute(global::System.AttributeTargets validOn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public bool AllowMultiple
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000407")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB660C", Offset = "0x1BB660C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000408")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB6614", Offset = "0x1BB6614", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public bool Inherited
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000409")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB6620", Offset = "0x1BB6620", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600040A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB6628", Offset = "0x1BB6628", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600040B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6634", Offset = "0x1BB6634", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static AttributeUsageAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.AttributeTargets _attributeTarget;

		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool _allowMultiple;

		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
		private bool _inherited;

		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		internal static global::System.AttributeUsageAttribute Default;
	}
}
