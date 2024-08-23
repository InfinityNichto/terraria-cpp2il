using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000424 RID: 1060
	[global::Cpp2ILInjected.Token(Token = "0x20004E3")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class ParameterInfo : ICustomAttributeProvider, global::System.Runtime.Serialization.IObjectReference, global::System.Runtime.InteropServices._ParameterInfo
	{
		// Token: 0x0600216D RID: 8557 RVA: 0x0001A267 File Offset: 0x00018467
		[global::Cpp2ILInjected.Token(Token = "0x6002407")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B837C0", Offset = "0x1B837C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(MemberInfo),
			typeof(global::System.Runtime.InteropServices.MarshalAsAttribute)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(MemberInfo),
			typeof(global::System.Runtime.InteropServices.MarshalAsAttribute)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "New", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(MemberInfo),
			typeof(global::System.Runtime.InteropServices.MarshalAsAttribute)
		}, ReturnType = typeof(ParameterInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ParameterInfo()
		{
			throw null;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0001A26A File Offset: 0x0001846A
		[global::Cpp2ILInjected.Token(Token = "0x170004C4")]
		public virtual ParameterAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002408")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B837C8", Offset = "0x1B837C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x0001A26D File Offset: 0x0001846D
		[global::Cpp2ILInjected.Token(Token = "0x170004C5")]
		public virtual MemberInfo Member
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002409")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B837D0", Offset = "0x1B837D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0001A270 File Offset: 0x00018470
		[global::Cpp2ILInjected.Token(Token = "0x170004C6")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600240A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B837D8", Offset = "0x1B837D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x0001A273 File Offset: 0x00018473
		[global::Cpp2ILInjected.Token(Token = "0x170004C7")]
		public virtual global::System.Type ParameterType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600240B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B837E0", Offset = "0x1B837E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x0001A276 File Offset: 0x00018476
		[global::Cpp2ILInjected.Token(Token = "0x170004C8")]
		public virtual int Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600240C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B837E8", Offset = "0x1B837E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x0001A279 File Offset: 0x00018479
		[global::Cpp2ILInjected.Token(Token = "0x170004C9")]
		public bool IsIn
		{
			[global::Cpp2ILInjected.Token(Token = "0x600240D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B837F0", Offset = "0x1B837F0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x0001A27C File Offset: 0x0001847C
		[global::Cpp2ILInjected.Token(Token = "0x170004CA")]
		public bool IsOptional
		{
			[global::Cpp2ILInjected.Token(Token = "0x600240E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8380C", Offset = "0x1B8380C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new object[]
			{
				typeof(MethodBase),
				typeof(BindingFlags),
				typeof(BindingFlags),
				typeof(CallingConventions),
				typeof(global::System.Type[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x0001A27F File Offset: 0x0001847F
		[global::Cpp2ILInjected.Token(Token = "0x170004CB")]
		public bool IsOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x600240F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B83828", Offset = "0x1B83828", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
			{
				typeof(global::System.MarshalByRefObject),
				typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "ProcessResponse", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage),
				typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage)
			}, ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ArgInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MethodBase),
				typeof(global::System.Runtime.Remoting.Messaging.ArgInfoType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "InitMessage", MemberParameters = new object[]
			{
				typeof(RuntimeMethodInfo),
				typeof(object[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x0001A282 File Offset: 0x00018482
		[global::Cpp2ILInjected.Token(Token = "0x170004CC")]
		public virtual object DefaultValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002410")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B83844", Offset = "0x1B83844", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x0001A285 File Offset: 0x00018485
		[global::Cpp2ILInjected.Token(Token = "0x6002411")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8386C", Offset = "0x1B8386C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0001A288 File Offset: 0x00018488
		[global::Cpp2ILInjected.Token(Token = "0x6002412")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8391C", Offset = "0x1B8391C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0001A28B File Offset: 0x0001848B
		[global::Cpp2ILInjected.Token(Token = "0x6002413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83998", Offset = "0x1B83998", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0001A28E File Offset: 0x0001848E
		[global::Cpp2ILInjected.Token(Token = "0x6002414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83A98", Offset = "0x1B83A98", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0001A291 File Offset: 0x00018491
		[global::Cpp2ILInjected.Token(Token = "0x6002415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83CD0", Offset = "0x1B83CD0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "FormatTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040010DE RID: 4318
		[global::Cpp2ILInjected.Token(Token = "0x40013F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected ParameterAttributes AttrsImpl;

		// Token: 0x040010DF RID: 4319
		[global::Cpp2ILInjected.Token(Token = "0x40013F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected global::System.Type ClassImpl;

		// Token: 0x040010E0 RID: 4320
		[global::Cpp2ILInjected.Token(Token = "0x40013FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected object DefaultValueImpl;

		// Token: 0x040010E1 RID: 4321
		[global::Cpp2ILInjected.Token(Token = "0x40013FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected MemberInfo MemberImpl;

		// Token: 0x040010E2 RID: 4322
		[global::Cpp2ILInjected.Token(Token = "0x40013FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected string NameImpl;

		// Token: 0x040010E3 RID: 4323
		[global::Cpp2ILInjected.Token(Token = "0x40013FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected int PositionImpl;

		// Token: 0x040010E4 RID: 4324
		[global::Cpp2ILInjected.Token(Token = "0x40013FE")]
		private const int MetadataToken_ParamDef = 134217728;
	}
}
