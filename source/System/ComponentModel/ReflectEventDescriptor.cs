﻿using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003B3")]
	internal sealed class ReflectEventDescriptor : EventDescriptor
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B634", Offset = "0x1E5B634", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateEvent", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public ReflectEventDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B7BC", Offset = "0x1E5B7BC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001944")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B924", Offset = "0x1E5B924", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateEvent", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(EventDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ReflectEventDescriptor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005C8")]
		public override Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001945")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5B9CC", Offset = "0x1E5B9CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005C9")]
		public override Type EventType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001946")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5B9D4", Offset = "0x1E5B9D4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005CA")]
		public override bool IsMulticast
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001947")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5BDF4", Offset = "0x1E5BDF4", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5BE9C", Offset = "0x1E5BE9C", Length = "0x700")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public override void AddEventHandler(object component, Delegate value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001949")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5C59C", Offset = "0x1E5C59C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(EventInfo),
			typeof(EventInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = "FillEventInfoAttribute", MemberParameters = new object[]
		{
			typeof(EventInfo),
			typeof(IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = "FillSingleMethodAttribute", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		protected override void FillAttributes(IList attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5C604", Offset = "0x1E5C604", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5B9EC", Offset = "0x1E5B9EC", Length = "0x408")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "get_EventType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "AddEventHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "RemoveEventHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(EventInfo),
			typeof(EventInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetEvent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FindMethod", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[]),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = "GetAddMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = "GetRemoveMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void FillMethods()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5C8EC", Offset = "0x1E5C8EC", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600194D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5CC14", Offset = "0x1E5CC14", Length = "0x644")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public override void RemoveEventHandler(object component, Delegate value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Type _type;

		[global::Cpp2ILInjected.Token(Token = "0x40012BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private readonly Type _componentClass;

		[global::Cpp2ILInjected.Token(Token = "0x40012BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private MethodInfo _addMethod;

		[global::Cpp2ILInjected.Token(Token = "0x40012BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private MethodInfo _removeMethod;

		[global::Cpp2ILInjected.Token(Token = "0x40012C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EventInfo _realEvent;

		[global::Cpp2ILInjected.Token(Token = "0x40012C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool _filledMethods;
	}
}
