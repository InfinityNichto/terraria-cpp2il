using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000431 RID: 1073
	[global::Cpp2ILInjected.Token(Token = "0x20004F0")]
	internal abstract class SignatureType : global::System.Type
	{
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x0001A387 File Offset: 0x00018587
		[global::Cpp2ILInjected.Token(Token = "0x170004F5")]
		public sealed override bool IsSignatureType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002476")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84E04", Offset = "0x1B84E04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021DD RID: 8669
		[global::Cpp2ILInjected.Token(Token = "0x6002477")]
		protected abstract override bool HasElementTypeImpl();

		// Token: 0x060021DE RID: 8670
		[global::Cpp2ILInjected.Token(Token = "0x6002478")]
		protected abstract override bool IsArrayImpl();

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060021DF RID: 8671
		[global::Cpp2ILInjected.Token(Token = "0x170004F6")]
		public abstract override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002479")]
			get;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060021E0 RID: 8672
		[global::Cpp2ILInjected.Token(Token = "0x170004F7")]
		public abstract override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247A")]
			get;
		}

		// Token: 0x060021E1 RID: 8673
		[global::Cpp2ILInjected.Token(Token = "0x600247B")]
		protected abstract override bool IsByRefImpl();

		// Token: 0x060021E2 RID: 8674
		[global::Cpp2ILInjected.Token(Token = "0x600247C")]
		protected abstract override bool IsPointerImpl();

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x0001A38A File Offset: 0x0001858A
		[global::Cpp2ILInjected.Token(Token = "0x170004F8")]
		public sealed override bool IsGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84E0C", Offset = "0x1B84E0C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060021E4 RID: 8676
		[global::Cpp2ILInjected.Token(Token = "0x170004F9")]
		public abstract override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247E")]
			get;
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060021E5 RID: 8677
		[global::Cpp2ILInjected.Token(Token = "0x170004FA")]
		public abstract override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247F")]
			get;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060021E6 RID: 8678
		[global::Cpp2ILInjected.Token(Token = "0x170004FB")]
		public abstract override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002480")]
			get;
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060021E7 RID: 8679
		[global::Cpp2ILInjected.Token(Token = "0x170004FC")]
		public abstract override bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002481")]
			get;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060021E8 RID: 8680
		[global::Cpp2ILInjected.Token(Token = "0x170004FD")]
		public abstract override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002482")]
			get;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0001A38D File Offset: 0x0001858D
		[global::Cpp2ILInjected.Token(Token = "0x170004FE")]
		public sealed override MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002483")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B84E4C", Offset = "0x1B84E4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0001A390 File Offset: 0x00018590
		[global::Cpp2ILInjected.Token(Token = "0x6002484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84E54", Offset = "0x1B84E54", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override global::System.Type MakeArrayType()
		{
			throw null;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0001A393 File Offset: 0x00018593
		[global::Cpp2ILInjected.Token(Token = "0x6002485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84EB8", Offset = "0x1B84EB8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public sealed override global::System.Type MakeArrayType(int rank)
		{
			throw null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0001A396 File Offset: 0x00018596
		[global::Cpp2ILInjected.Token(Token = "0x6002486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84F5C", Offset = "0x1B84F5C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override global::System.Type MakeByRefType()
		{
			throw null;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0001A399 File Offset: 0x00018599
		[global::Cpp2ILInjected.Token(Token = "0x6002487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84FB4", Offset = "0x1B84FB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override global::System.Type MakePointerType()
		{
			throw null;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0001A39C File Offset: 0x0001859C
		[global::Cpp2ILInjected.Token(Token = "0x6002488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8500C", Offset = "0x1B8500C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type MakeGenericType(params global::System.Type[] typeArguments)
		{
			throw null;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0001A39F File Offset: 0x0001859F
		[global::Cpp2ILInjected.Token(Token = "0x6002489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85058", Offset = "0x1B85058", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override global::System.Type GetElementType()
		{
			throw null;
		}

		// Token: 0x060021F0 RID: 8688
		[global::Cpp2ILInjected.Token(Token = "0x600248A")]
		public abstract override int GetArrayRank();

		// Token: 0x060021F1 RID: 8689
		[global::Cpp2ILInjected.Token(Token = "0x600248B")]
		public abstract override global::System.Type GetGenericTypeDefinition();

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060021F2 RID: 8690
		[global::Cpp2ILInjected.Token(Token = "0x170004FF")]
		public abstract override global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x600248C")]
			get;
		}

		// Token: 0x060021F3 RID: 8691
		[global::Cpp2ILInjected.Token(Token = "0x600248D")]
		public abstract override global::System.Type[] GetGenericArguments();

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060021F4 RID: 8692
		[global::Cpp2ILInjected.Token(Token = "0x17000500")]
		public abstract override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600248E")]
			get;
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060021F5 RID: 8693
		[global::Cpp2ILInjected.Token(Token = "0x17000501")]
		internal abstract SignatureType ElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600248F")]
			get;
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x0001A3A2 File Offset: 0x000185A2
		[global::Cpp2ILInjected.Token(Token = "0x17000502")]
		public sealed override global::System.Type UnderlyingSystemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002490")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85068", Offset = "0x1B85068", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060021F7 RID: 8695
		[global::Cpp2ILInjected.Token(Token = "0x17000503")]
		public abstract override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002491")]
			get;
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060021F8 RID: 8696
		[global::Cpp2ILInjected.Token(Token = "0x17000504")]
		public abstract override string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002492")]
			get;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0001A3A5 File Offset: 0x000185A5
		[global::Cpp2ILInjected.Token(Token = "0x17000505")]
		public sealed override string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002493")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8506C", Offset = "0x1B8506C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0001A3A8 File Offset: 0x000185A8
		[global::Cpp2ILInjected.Token(Token = "0x17000506")]
		public sealed override string AssemblyQualifiedName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002494")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85074", Offset = "0x1B85074", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060021FB RID: 8699
		[global::Cpp2ILInjected.Token(Token = "0x6002495")]
		public abstract override string ToString();

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x0001A3AB File Offset: 0x000185AB
		[global::Cpp2ILInjected.Token(Token = "0x17000507")]
		public sealed override Assembly Assembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002496")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8507C", Offset = "0x1B8507C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x0001A3AE File Offset: 0x000185AE
		[global::Cpp2ILInjected.Token(Token = "0x17000508")]
		public sealed override Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002497")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B850C8", Offset = "0x1B850C8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x0001A3B1 File Offset: 0x000185B1
		[global::Cpp2ILInjected.Token(Token = "0x17000509")]
		public sealed override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002498")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85114", Offset = "0x1B85114", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x0001A3B4 File Offset: 0x000185B4
		[global::Cpp2ILInjected.Token(Token = "0x1700050A")]
		public sealed override global::System.Type BaseType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002499")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85160", Offset = "0x1B85160", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0001A3B7 File Offset: 0x000185B7
		[global::Cpp2ILInjected.Token(Token = "0x600249A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B851AC", Offset = "0x1B851AC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type[] GetInterfaces()
		{
			throw null;
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0001A3BA File Offset: 0x000185BA
		[global::Cpp2ILInjected.Token(Token = "0x600249B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B851F8", Offset = "0x1B851F8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsAssignableFrom(global::System.Type c)
		{
			throw null;
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x0001A3BD File Offset: 0x000185BD
		[global::Cpp2ILInjected.Token(Token = "0x1700050B")]
		public sealed override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x600249C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85244", Offset = "0x1B85244", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x0001A3C0 File Offset: 0x000185C0
		[global::Cpp2ILInjected.Token(Token = "0x1700050C")]
		public sealed override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600249D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85290", Offset = "0x1B85290", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x0001A3C3 File Offset: 0x000185C3
		[global::Cpp2ILInjected.Token(Token = "0x1700050D")]
		public sealed override MethodBase DeclaringMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x600249E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B852DC", Offset = "0x1B852DC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0001A3C6 File Offset: 0x000185C6
		[global::Cpp2ILInjected.Token(Token = "0x600249F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85328", Offset = "0x1B85328", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type[] GetGenericParameterConstraints()
		{
			throw null;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x0001A3C9 File Offset: 0x000185C9
		[global::Cpp2ILInjected.Token(Token = "0x1700050E")]
		public sealed override GenericParameterAttributes GenericParameterAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85374", Offset = "0x1B85374", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0001A3CC File Offset: 0x000185CC
		[global::Cpp2ILInjected.Token(Token = "0x60024A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B853C0", Offset = "0x1B853C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsEnumDefined(object value)
		{
			throw null;
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0001A3CF File Offset: 0x000185CF
		[global::Cpp2ILInjected.Token(Token = "0x60024A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8540C", Offset = "0x1B8540C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override string GetEnumName(object value)
		{
			throw null;
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0001A3D2 File Offset: 0x000185D2
		[global::Cpp2ILInjected.Token(Token = "0x60024A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85458", Offset = "0x1B85458", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override string[] GetEnumNames()
		{
			throw null;
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0001A3D5 File Offset: 0x000185D5
		[global::Cpp2ILInjected.Token(Token = "0x60024A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B854A4", Offset = "0x1B854A4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type GetEnumUnderlyingType()
		{
			throw null;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0001A3D8 File Offset: 0x000185D8
		[global::Cpp2ILInjected.Token(Token = "0x60024A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B854F0", Offset = "0x1B854F0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Array GetEnumValues()
		{
			throw null;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0001A3DB File Offset: 0x000185DB
		[global::Cpp2ILInjected.Token(Token = "0x60024A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8553C", Offset = "0x1B8553C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override global::System.TypeCode GetTypeCodeImpl()
		{
			throw null;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0001A3DE File Offset: 0x000185DE
		[global::Cpp2ILInjected.Token(Token = "0x60024A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85588", Offset = "0x1B85588", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override TypeAttributes GetAttributeFlagsImpl()
		{
			throw null;
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0001A3E1 File Offset: 0x000185E1
		[global::Cpp2ILInjected.Token(Token = "0x60024A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B855D4", Offset = "0x1B855D4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0001A3E4 File Offset: 0x000185E4
		[global::Cpp2ILInjected.Token(Token = "0x60024A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85620", Offset = "0x1B85620", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0001A3E7 File Offset: 0x000185E7
		[global::Cpp2ILInjected.Token(Token = "0x60024AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8566C", Offset = "0x1B8566C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0001A3EA File Offset: 0x000185EA
		[global::Cpp2ILInjected.Token(Token = "0x60024AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B856B8", Offset = "0x1B856B8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0001A3ED File Offset: 0x000185ED
		[global::Cpp2ILInjected.Token(Token = "0x60024AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85704", Offset = "0x1B85704", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0001A3F0 File Offset: 0x000185F0
		[global::Cpp2ILInjected.Token(Token = "0x60024AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85750", Offset = "0x1B85750", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0001A3F3 File Offset: 0x000185F3
		[global::Cpp2ILInjected.Token(Token = "0x60024AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8579C", Offset = "0x1B8579C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0001A3F6 File Offset: 0x000185F6
		[global::Cpp2ILInjected.Token(Token = "0x60024AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B857E8", Offset = "0x1B857E8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0001A3F9 File Offset: 0x000185F9
		[global::Cpp2ILInjected.Token(Token = "0x60024B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85834", Offset = "0x1B85834", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] namedParameters)
		{
			throw null;
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0001A3FC File Offset: 0x000185FC
		[global::Cpp2ILInjected.Token(Token = "0x60024B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85880", Offset = "0x1B85880", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, global::System.Type[] types, ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0001A3FF File Offset: 0x000185FF
		[global::Cpp2ILInjected.Token(Token = "0x60024B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B858CC", Offset = "0x1B858CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, global::System.Type returnType, global::System.Type[] types, ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0001A402 File Offset: 0x00018602
		[global::Cpp2ILInjected.Token(Token = "0x60024B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85918", Offset = "0x1B85918", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0001A405 File Offset: 0x00018605
		[global::Cpp2ILInjected.Token(Token = "0x60024B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85964", Offset = "0x1B85964", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0001A408 File Offset: 0x00018608
		[global::Cpp2ILInjected.Token(Token = "0x60024B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B859B0", Offset = "0x1B859B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0001A40B File Offset: 0x0001860B
		[global::Cpp2ILInjected.Token(Token = "0x60024B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B859FC", Offset = "0x1B859FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0001A40E File Offset: 0x0001860E
		[global::Cpp2ILInjected.Token(Token = "0x60024B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85A48", Offset = "0x1B85A48", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0001A411 File Offset: 0x00018611
		[global::Cpp2ILInjected.Token(Token = "0x60024B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85A94", Offset = "0x1B85A94", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, global::System.Type[] types, ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0001A414 File Offset: 0x00018614
		[global::Cpp2ILInjected.Token(Token = "0x60024B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85AE0", Offset = "0x1B85AE0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsCOMObjectImpl()
		{
			throw null;
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0001A417 File Offset: 0x00018617
		[global::Cpp2ILInjected.Token(Token = "0x60024BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85B2C", Offset = "0x1B85B2C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsPrimitiveImpl()
		{
			throw null;
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0001A41A File Offset: 0x0001861A
		[global::Cpp2ILInjected.Token(Token = "0x60024BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85B78", Offset = "0x1B85B78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsContextfulImpl()
		{
			throw null;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x0001A41D File Offset: 0x0001861D
		[global::Cpp2ILInjected.Token(Token = "0x1700050F")]
		public sealed override bool IsEnum
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85BC4", Offset = "0x1B85BC4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0001A420 File Offset: 0x00018620
		[global::Cpp2ILInjected.Token(Token = "0x60024BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85C10", Offset = "0x1B85C10", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsEquivalentTo(global::System.Type other)
		{
			throw null;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0001A423 File Offset: 0x00018623
		[global::Cpp2ILInjected.Token(Token = "0x60024BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85C5C", Offset = "0x1B85C5C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsInstanceOfType(object o)
		{
			throw null;
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0001A426 File Offset: 0x00018626
		[global::Cpp2ILInjected.Token(Token = "0x60024BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85CA8", Offset = "0x1B85CA8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsMarshalByRefImpl()
		{
			throw null;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x0001A429 File Offset: 0x00018629
		[global::Cpp2ILInjected.Token(Token = "0x17000510")]
		public sealed override bool IsSerializable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85CF4", Offset = "0x1B85CF4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0001A42C File Offset: 0x0001862C
		[global::Cpp2ILInjected.Token(Token = "0x60024C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85D40", Offset = "0x1B85D40", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsSubclassOf(global::System.Type c)
		{
			throw null;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0001A42F File Offset: 0x0001862F
		[global::Cpp2ILInjected.Token(Token = "0x60024C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85D8C", Offset = "0x1B85D8C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsValueTypeImpl()
		{
			throw null;
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x0001A432 File Offset: 0x00018632
		[global::Cpp2ILInjected.Token(Token = "0x17000511")]
		public sealed override global::System.RuntimeTypeHandle TypeHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B85DD8", Offset = "0x1B85DD8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0001A435 File Offset: 0x00018635
		[global::Cpp2ILInjected.Token(Token = "0x60024C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8474C", Offset = "0x1B8474C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureArrayType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SignatureType),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureByRefType), Member = ".ctor", MemberParameters = new object[] { typeof(SignatureType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureConstructedGenericType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureHasElementType), Member = ".ctor", MemberParameters = new object[] { typeof(SignatureType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignaturePointerType), Member = ".ctor", MemberParameters = new object[] { typeof(SignatureType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureType), Member = "MakeArrayType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureType), Member = "MakeArrayType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureType), Member = "MakeByRefType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SignatureType), Member = "MakePointerType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SignatureType()
		{
			throw null;
		}
	}
}
