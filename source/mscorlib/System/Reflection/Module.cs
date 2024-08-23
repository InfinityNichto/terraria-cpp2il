using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000422 RID: 1058
	[global::Cpp2ILInjected.Token(Token = "0x20004E1")]
	[global::System.Serializable]
	[StructLayout(0)]
	public abstract class Module : ICustomAttributeProvider, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.InteropServices._Module
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x0001A231 File Offset: 0x00018431
		[global::Cpp2ILInjected.Token(Token = "0x60023F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83170", Offset = "0x1B83170", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Module()
		{
			throw null;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0001A234 File Offset: 0x00018434
		[global::Cpp2ILInjected.Token(Token = "0x170004C0")]
		public virtual Assembly Assembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B83178", Offset = "0x1B83178", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x0001A237 File Offset: 0x00018437
		[global::Cpp2ILInjected.Token(Token = "0x170004C1")]
		public virtual string FullyQualifiedName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B831A0", Offset = "0x1B831A0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0001A23A File Offset: 0x0001843A
		[global::Cpp2ILInjected.Token(Token = "0x170004C2")]
		public virtual global::System.Guid ModuleVersionId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B831C8", Offset = "0x1B831C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x0001A23D File Offset: 0x0001843D
		[global::Cpp2ILInjected.Token(Token = "0x170004C3")]
		public virtual string ScopeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B831F0", Offset = "0x1B831F0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0001A240 File Offset: 0x00018440
		[global::Cpp2ILInjected.Token(Token = "0x60023FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83218", Offset = "0x1B83218", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual bool IsResource()
		{
			throw null;
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0001A243 File Offset: 0x00018443
		[global::Cpp2ILInjected.Token(Token = "0x60023FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83240", Offset = "0x1B83240", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0001A246 File Offset: 0x00018446
		[global::Cpp2ILInjected.Token(Token = "0x60023FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83268", Offset = "0x1B83268", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0001A249 File Offset: 0x00018449
		[global::Cpp2ILInjected.Token(Token = "0x60023FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83290", Offset = "0x1B83290", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0001A24C File Offset: 0x0001844C
		[global::Cpp2ILInjected.Token(Token = "0x60023FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B832B8", Offset = "0x1B832B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0001A24F File Offset: 0x0001844F
		[global::Cpp2ILInjected.Token(Token = "0x60023FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B832E0", Offset = "0x1B832E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0001A252 File Offset: 0x00018452
		[global::Cpp2ILInjected.Token(Token = "0x6002400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B832E8", Offset = "0x1B832E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x0001A255 File Offset: 0x00018455
		[global::Cpp2ILInjected.Token(Token = "0x6002401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B832F0", Offset = "0x1B832F0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(Module),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(Module),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetPopulatedTypes", MemberParameters = new object[] { typeof(Module) }, ReturnType = "System.Type[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "Refresh", MemberParameters = new object[] { typeof(Module) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(Module left, Module right)
		{
			throw null;
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0001A258 File Offset: 0x00018458
		[global::Cpp2ILInjected.Token(Token = "0x6002402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8331C", Offset = "0x1B8331C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x0001A25B File Offset: 0x0001845B
		[global::Cpp2ILInjected.Token(Token = "0x6002403")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83328", Offset = "0x1B83328", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool FilterTypeNameImpl(global::System.Type cls, object filterCriteria)
		{
			throw null;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0001A25E File Offset: 0x0001845E
		[global::Cpp2ILInjected.Token(Token = "0x6002404")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83444", Offset = "0x1B83444", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool FilterTypeNameIgnoreCaseImpl(global::System.Type cls, object filterCriteria)
		{
			throw null;
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0001A261 File Offset: 0x00018461
		[global::Cpp2ILInjected.Token(Token = "0x6002405")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83590", Offset = "0x1B83590", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal virtual global::System.Guid GetModuleVersionId()
		{
			throw null;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0001A264 File Offset: 0x00018464
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002406")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B835C8", Offset = "0x1B835C8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeFilter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static Module()
		{
			throw null;
		}

		// Token: 0x040010CF RID: 4303
		[global::Cpp2ILInjected.Token(Token = "0x40013E9")]
		public static readonly TypeFilter FilterTypeName;

		// Token: 0x040010D0 RID: 4304
		[global::Cpp2ILInjected.Token(Token = "0x40013EA")]
		public static readonly TypeFilter FilterTypeNameIgnoreCase;

		// Token: 0x040010D1 RID: 4305
		[global::Cpp2ILInjected.Token(Token = "0x40013EB")]
		private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
	}
}
