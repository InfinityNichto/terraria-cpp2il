using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C2 RID: 706
	[global::Cpp2ILInjected.Token(Token = "0x20003C0")]
	public abstract class TypeDescriptionProvider
	{
		// Token: 0x06001726 RID: 5926 RVA: 0x00006F7A File Offset: 0x0000517A
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

		// Token: 0x06001727 RID: 5927 RVA: 0x00006F7D File Offset: 0x0000517D
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

		// Token: 0x06001728 RID: 5928 RVA: 0x00006F80 File Offset: 0x00005180
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

		// Token: 0x06001729 RID: 5929 RVA: 0x00006F83 File Offset: 0x00005183
		[global::Cpp2ILInjected.Token(Token = "0x600198A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EC50", Offset = "0x1E5EC50", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual IDictionary GetCache(object instance)
		{
			throw null;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00006F86 File Offset: 0x00005186
		[global::Cpp2ILInjected.Token(Token = "0x600198B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EC68", Offset = "0x1E5EC68", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomTypeDescriptor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			throw null;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00006F89 File Offset: 0x00005189
		[global::Cpp2ILInjected.Token(Token = "0x600198C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5ECF8", Offset = "0x1E5ECF8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			throw null;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00006F8C File Offset: 0x0000518C
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

		// Token: 0x0600172D RID: 5933 RVA: 0x00006F8F File Offset: 0x0000518F
		[global::Cpp2ILInjected.Token(Token = "0x600198E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EF3C", Offset = "0x1E5EF3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Type GetReflectionType(Type objectType)
		{
			throw null;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00006F92 File Offset: 0x00005192
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

		// Token: 0x0600172F RID: 5935 RVA: 0x00006F95 File Offset: 0x00005195
		[global::Cpp2ILInjected.Token(Token = "0x6001990")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EFD4", Offset = "0x1E5EFD4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			throw null;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00006F98 File Offset: 0x00005198
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

		// Token: 0x06001731 RID: 5937 RVA: 0x00006F9B File Offset: 0x0000519B
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

		// Token: 0x06001732 RID: 5938 RVA: 0x00006F9E File Offset: 0x0000519E
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

		// Token: 0x06001733 RID: 5939 RVA: 0x00006FA1 File Offset: 0x000051A1
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

		// Token: 0x06001734 RID: 5940 RVA: 0x00006FA4 File Offset: 0x000051A4
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

		// Token: 0x04000EB7 RID: 3767
		[global::Cpp2ILInjected.Token(Token = "0x40012D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly TypeDescriptionProvider _parent;

		// Token: 0x04000EB8 RID: 3768
		[global::Cpp2ILInjected.Token(Token = "0x40012D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

		// Token: 0x02000460 RID: 1120
		[global::Cpp2ILInjected.Token(Token = "0x20003C1")]
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
			// Token: 0x06001EF7 RID: 7927 RVA: 0x00008564 File Offset: 0x00006764
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
