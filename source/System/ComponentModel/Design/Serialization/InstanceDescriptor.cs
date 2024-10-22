﻿using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000414")]
	public sealed class InstanceDescriptor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8BF04", Offset = "0x1E8BF04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfoConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecimalConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GuidConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeOffsetConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumConverter), Member = "ConvertTo", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public InstanceDescriptor(MemberInfo member, ICollection arguments)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8BF0C", Offset = "0x1E8BF0C", Length = "0x4D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700063C")]
		public ICollection Arguments
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001C19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C3E4", Offset = "0x1E8C3E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700063D")]
		public MemberInfo MemberInfo
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001C1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C3EC", Offset = "0x1E8C3EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C3F4", Offset = "0x1E8C3F4", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InstanceDescriptor), Member = "Invoke", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public object Invoke()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400138E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ICollection <Arguments>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400138F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool <IsComplete>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001390")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly MemberInfo <MemberInfo>k__BackingField;
	}
}
