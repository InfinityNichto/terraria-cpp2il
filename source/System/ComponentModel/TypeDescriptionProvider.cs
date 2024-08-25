using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C0")]
	public abstract class TypeDescriptionProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001987")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48F34", Offset = "0x1E48F34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.ComNativeDescriptionProvider", Member = ".ctor", MemberParameters = new object[] { typeof(IComNativeDescriptorHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode", Member = ".ctor", MemberParameters = new object[] { typeof(TypeDescriptionProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "NodeFor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TypeDescriptionProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001988")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EB1C", Offset = "0x1E5EB1C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TypeDescriptionProvider(TypeDescriptionProvider parent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001989")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EB44", Offset = "0x1E5EB44", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EC50", Offset = "0x1E5EC50", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual IDictionary GetCache(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EC68", Offset = "0x1E5EC68", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5ECF8", Offset = "0x1E5ECF8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EDE8", Offset = "0x1E5EDE8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = "GetTypeDescriptor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual string GetFullComponentName(object component)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EF3C", Offset = "0x1E5EF3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Type GetReflectionType(Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600198F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EF4C", Offset = "0x1E5EF4C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Type GetReflectionType(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001990")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EFD4", Offset = "0x1E5EFD4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001991")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EFF0", Offset = "0x1E5EFF0", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual Type GetRuntimeType(Type reflectionType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001992")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F15C", Offset = "0x1E5F15C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001993")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EEB4", Offset = "0x1E5EEB4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptionProvider), Member = "GetFullComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetDescriptor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ICustomTypeDescriptor GetTypeDescriptor(object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001994")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F16C", Offset = "0x1E5F16C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider", Member = "GetTypeDescriptor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(ICustomTypeDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001995")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F208", Offset = "0x1E5F208", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual bool IsSupportedType(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly TypeDescriptionProvider _parent;

		[global::Cpp2ILInjected.Token(Token = "0x40012D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

		[global::Cpp2ILInjected.Token(Token = "0x20003C1")]
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001996")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5ECF0", Offset = "0x1E5ECF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = ".ctor", ReturnType = typeof(void))]
			public EmptyCustomTypeDescriptor()
			{
				throw null;
			}
		}
	}
}
