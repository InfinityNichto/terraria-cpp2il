using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000415 RID: 1045
	[global::Cpp2ILInjected.Token(Token = "0x20004D4")]
	[global::System.Serializable]
	public abstract class FieldInfo : MemberInfo
	{
		// Token: 0x060020F6 RID: 8438 RVA: 0x0001A14D File Offset: 0x0001834D
		[global::Cpp2ILInjected.Token(Token = "0x6002390")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80E9C", Offset = "0x1B80E9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationFieldInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(RuntimeFieldInfo),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RtFieldInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected FieldInfo()
		{
			throw null;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0001A150 File Offset: 0x00018350
		[global::Cpp2ILInjected.Token(Token = "0x1700049D")]
		public override MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002391")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80EA4", Offset = "0x1B80EA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060020F8 RID: 8440
		[global::Cpp2ILInjected.Token(Token = "0x1700049E")]
		public abstract FieldAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002392")]
			get;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060020F9 RID: 8441
		[global::Cpp2ILInjected.Token(Token = "0x1700049F")]
		public abstract global::System.Type FieldType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002393")]
			get;
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0001A153 File Offset: 0x00018353
		[global::Cpp2ILInjected.Token(Token = "0x170004A0")]
		public bool IsInitOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002394")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80EAC", Offset = "0x1B80EAC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x0001A156 File Offset: 0x00018356
		[global::Cpp2ILInjected.Token(Token = "0x170004A1")]
		public bool IsLiteral
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002395")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80ECC", Offset = "0x1B80ECC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils.<>c", Member = "<GetValues>b__5_0", MemberParameters = new object[] { typeof(FieldInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils.<>c", Member = "<GetNames>b__6_0", MemberParameters = new object[] { typeof(FieldInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0001A159 File Offset: 0x00018359
		[global::Cpp2ILInjected.Token(Token = "0x170004A2")]
		public bool IsNotSerialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002396")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80EEC", Offset = "0x1B80EEC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(MemberInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0001A15C File Offset: 0x0001835C
		[global::Cpp2ILInjected.Token(Token = "0x170004A3")]
		public bool IsStatic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002397")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80F0C", Offset = "0x1B80F0C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypedReference), Member = "MakeTypedReference", MemberParameters = new object[]
			{
				typeof(object),
				typeof(FieldInfo[])
			}, ReturnType = typeof(global::System.TypedReference))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Attribute))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(global::System.Collections.ICollection),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.Collections.Generic.List`1<MemberInfo>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0001A15F File Offset: 0x0001835F
		[global::Cpp2ILInjected.Token(Token = "0x170004A4")]
		public bool IsPrivate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002398")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80F2C", Offset = "0x1B80F2C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils.<>c", Member = "<GetChildPrivateFields>b__39_0", MemberParameters = new object[] { typeof(FieldInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x0001A162 File Offset: 0x00018362
		[global::Cpp2ILInjected.Token(Token = "0x170004A5")]
		public bool IsPublic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002399")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80F54", Offset = "0x1B80F54", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanReadMemberValue", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06002100 RID: 8448
		[global::Cpp2ILInjected.Token(Token = "0x170004A6")]
		public abstract global::System.RuntimeFieldHandle FieldHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x600239A")]
			get;
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x0001A165 File Offset: 0x00018365
		[global::Cpp2ILInjected.Token(Token = "0x600239B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80F7C", Offset = "0x1B80F7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0001A168 File Offset: 0x00018368
		[global::Cpp2ILInjected.Token(Token = "0x600239C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80F84", Offset = "0x1B80F84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0001A16B File Offset: 0x0001836B
		[global::Cpp2ILInjected.Token(Token = "0x600239D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80F8C", Offset = "0x1B80F8C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypedReference), Member = "MakeTypedReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FieldInfo[])
		}, ReturnType = typeof(global::System.TypedReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(FieldInfo),
			typeof(global::System.Runtime.Serialization.ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			throw null;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0001A16E File Offset: 0x0001836E
		[global::Cpp2ILInjected.Token(Token = "0x600239E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80FB8", Offset = "0x1B80FB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Reflection.IdDictionary", Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = "ReLogic.Reflection.IdDictionary")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object),
			typeof(object[]),
			typeof(ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "SerializationSetValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MemberInfo[])
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(FieldInfo),
			typeof(global::System.Runtime.Serialization.ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.ISerializationSurrogate),
			typeof(long),
			typeof(FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectHolder), Member = "UpdateData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.ISerializationSurrogate),
			typeof(long),
			typeof(FieldInfo),
			typeof(int[]),
			typeof(global::System.Runtime.Serialization.ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationFieldInfo), Member = "InternalGetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationFieldInfo), Member = "InternalSetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			throw null;
		}

		// Token: 0x06002105 RID: 8453
		[global::Cpp2ILInjected.Token(Token = "0x600239F")]
		public abstract object GetValue(object obj);

		// Token: 0x06002106 RID: 8454 RVA: 0x0001A171 File Offset: 0x00018371
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60023A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80FF4", Offset = "0x1B80FF4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadFields", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0`1", Member = "<CreateSet>b__0", MemberParameters = new object[]
		{
			"T",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "SetMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetValue(object obj, object value)
		{
			throw null;
		}

		// Token: 0x06002107 RID: 8455
		[global::Cpp2ILInjected.Token(Token = "0x60023A1")]
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, global::System.Globalization.CultureInfo culture);

		// Token: 0x06002108 RID: 8456 RVA: 0x0001A174 File Offset: 0x00018374
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60023A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81080", Offset = "0x1B81080", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void SetValueDirect(global::System.TypedReference obj, object value)
		{
			throw null;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0001A177 File Offset: 0x00018377
		[global::Cpp2ILInjected.Token(Token = "0x60023A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B810CC", Offset = "0x1B810CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object GetRawConstantValue()
		{
			throw null;
		}

		// Token: 0x0600210A RID: 8458
		[global::Cpp2ILInjected.Token(Token = "0x60023A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81118", Offset = "0x1B81118", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern FieldInfo internal_from_handle_type(global::System.IntPtr field_handle, global::System.IntPtr type_handle);

		// Token: 0x0600210B RID: 8459 RVA: 0x0001A17A File Offset: 0x0001837A
		[global::Cpp2ILInjected.Token(Token = "0x60023A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8111C", Offset = "0x1B8111C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeFieldHandle), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static FieldInfo GetFieldFromHandle(global::System.RuntimeFieldHandle handle)
		{
			throw null;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0001A17D File Offset: 0x0001837D
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60023A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B811D0", Offset = "0x1B811D0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(RuntimeFieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static FieldInfo GetFieldFromHandle(global::System.RuntimeFieldHandle handle, global::System.RuntimeTypeHandle declaringType)
		{
			throw null;
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0001A180 File Offset: 0x00018380
		[global::Cpp2ILInjected.Token(Token = "0x60023A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B812B0", Offset = "0x1B812B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal virtual int GetFieldOffset()
		{
			throw null;
		}

		// Token: 0x0600210E RID: 8462
		[global::Cpp2ILInjected.Token(Token = "0x60023A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B812FC", Offset = "0x1B812FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Runtime.InteropServices.MarshalAsAttribute get_marshal_info();

		// Token: 0x0600210F RID: 8463 RVA: 0x0001A183 File Offset: 0x00018383
		[global::Cpp2ILInjected.Token(Token = "0x60023A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81300", Offset = "0x1B81300", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsExplicitLayout", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NonSerializedAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.FieldOffsetAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal object[] GetPseudoCustomAttributes()
		{
			throw null;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0001A186 File Offset: 0x00018386
		[global::Cpp2ILInjected.Token(Token = "0x60023AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B814D4", Offset = "0x1B814D4", Length = "0x50C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsExplicitLayout", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			throw null;
		}
	}
}
