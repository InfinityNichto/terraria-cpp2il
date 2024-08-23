using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200041B RID: 1051
	[global::Cpp2ILInjected.Token(Token = "0x20004DA")]
	[global::System.Serializable]
	public abstract class MemberInfo : ICustomAttributeProvider
	{
		// Token: 0x0600211E RID: 8478 RVA: 0x0001A1A1 File Offset: 0x000183A1
		[global::Cpp2ILInjected.Token(Token = "0x60023B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80AAC", Offset = "0x1B80AAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MemberInfo()
		{
			throw null;
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600211F RID: 8479
		[global::Cpp2ILInjected.Token(Token = "0x170004AA")]
		public abstract MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023B9")]
			get;
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06002120 RID: 8480
		[global::Cpp2ILInjected.Token(Token = "0x170004AB")]
		public abstract string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023BA")]
			get;
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06002121 RID: 8481
		[global::Cpp2ILInjected.Token(Token = "0x170004AC")]
		public abstract global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023BB")]
			get;
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06002122 RID: 8482
		[global::Cpp2ILInjected.Token(Token = "0x170004AD")]
		public abstract global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023BC")]
			get;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x0001A1A4 File Offset: 0x000183A4
		[global::Cpp2ILInjected.Token(Token = "0x170004AE")]
		public virtual Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81FF0", Offset = "0x1B81FF0", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002124 RID: 8484
		[global::Cpp2ILInjected.Token(Token = "0x60023BE")]
		public abstract bool IsDefined(global::System.Type attributeType, bool inherit);

		// Token: 0x06002125 RID: 8485
		[global::Cpp2ILInjected.Token(Token = "0x60023BF")]
		public abstract object[] GetCustomAttributes(bool inherit);

		// Token: 0x06002126 RID: 8486
		[global::Cpp2ILInjected.Token(Token = "0x60023C0")]
		public abstract object[] GetCustomAttributes(global::System.Type attributeType, bool inherit);

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x0001A1A7 File Offset: 0x000183A7
		[global::Cpp2ILInjected.Token(Token = "0x170004AF")]
		public virtual int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B820BC", Offset = "0x1B820BC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0001A1AA File Offset: 0x000183AA
		[global::Cpp2ILInjected.Token(Token = "0x60023C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80BF4", Offset = "0x1B80BF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0001A1AD File Offset: 0x000183AD
		[global::Cpp2ILInjected.Token(Token = "0x60023C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80C04", Offset = "0x1B80C04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0001A1B0 File Offset: 0x000183B0
		[global::Cpp2ILInjected.Token(Token = "0x60023C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B820F4", Offset = "0x1B820F4", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "PopulateObjectMembers", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MemberInfo[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MemberInfo[])
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "RecordFixup", MemberParameters = new object[]
		{
			typeof(long),
			typeof(MemberInfo),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParameterInfo), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(CustomAttributeTypedArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool operator ==(MemberInfo left, MemberInfo right)
		{
			throw null;
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0001A1B3 File Offset: 0x000183B3
		[global::Cpp2ILInjected.Token(Token = "0x60023C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82684", Offset = "0x1B82684", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(long),
			typeof(MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillEventInfoAttribute", MemberParameters = new object[]
		{
			typeof(EventInfo),
			typeof(global::System.Collections.IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillSingleMethodAttribute", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(global::System.Collections.IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new object[] { typeof(global::System.Collections.IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(MemberInfo left, MemberInfo right)
		{
			throw null;
		}
	}
}
