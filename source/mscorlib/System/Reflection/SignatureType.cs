using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004F0")]
	internal abstract class SignatureType : global::System.Type
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002477")]
		protected abstract override bool HasElementTypeImpl();

		[global::Cpp2ILInjected.Token(Token = "0x6002478")]
		protected abstract override bool IsArrayImpl();

		[global::Cpp2ILInjected.Token(Token = "0x170004F6")]
		public abstract override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002479")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004F7")]
		public abstract override bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600247B")]
		protected abstract override bool IsByRefImpl();

		[global::Cpp2ILInjected.Token(Token = "0x600247C")]
		protected abstract override bool IsPointerImpl();

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

		[global::Cpp2ILInjected.Token(Token = "0x170004F9")]
		public abstract override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004FA")]
		public abstract override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600247F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004FB")]
		public abstract override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002480")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004FC")]
		public abstract override bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002481")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004FD")]
		public abstract override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002482")]
			get;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84E54", Offset = "0x1B84E54", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override global::System.Type MakeArrayType()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84F5C", Offset = "0x1B84F5C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override global::System.Type MakeByRefType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B84FB4", Offset = "0x1B84FB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override global::System.Type MakePointerType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8500C", Offset = "0x1B8500C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type MakeGenericType(params global::System.Type[] typeArguments)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85058", Offset = "0x1B85058", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override global::System.Type GetElementType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600248A")]
		public abstract override int GetArrayRank();

		[global::Cpp2ILInjected.Token(Token = "0x600248B")]
		public abstract override global::System.Type GetGenericTypeDefinition();

		[global::Cpp2ILInjected.Token(Token = "0x170004FF")]
		public abstract override global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x600248C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600248D")]
		public abstract override global::System.Type[] GetGenericArguments();

		[global::Cpp2ILInjected.Token(Token = "0x17000500")]
		public abstract override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600248E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000501")]
		internal abstract SignatureType ElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600248F")]
			get;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x17000503")]
		public abstract override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002491")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000504")]
		public abstract override string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002492")]
			get;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002495")]
		public abstract override string ToString();

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

		[global::Cpp2ILInjected.Token(Token = "0x600249A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B851AC", Offset = "0x1B851AC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type[] GetInterfaces()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600249B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B851F8", Offset = "0x1B851F8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsAssignableFrom(global::System.Type c)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600249F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85328", Offset = "0x1B85328", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type[] GetGenericParameterConstraints()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60024A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B853C0", Offset = "0x1B853C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsEnumDefined(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8540C", Offset = "0x1B8540C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override string GetEnumName(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85458", Offset = "0x1B85458", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override string[] GetEnumNames()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B854A4", Offset = "0x1B854A4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type GetEnumUnderlyingType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B854F0", Offset = "0x1B854F0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Array GetEnumValues()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8553C", Offset = "0x1B8553C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override global::System.TypeCode GetTypeCodeImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85588", Offset = "0x1B85588", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override TypeAttributes GetAttributeFlagsImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B855D4", Offset = "0x1B855D4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85620", Offset = "0x1B85620", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8566C", Offset = "0x1B8566C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B856B8", Offset = "0x1B856B8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85704", Offset = "0x1B85704", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85750", Offset = "0x1B85750", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8579C", Offset = "0x1B8579C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override global::System.Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B857E8", Offset = "0x1B857E8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85834", Offset = "0x1B85834", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] namedParameters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85880", Offset = "0x1B85880", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, global::System.Type[] types, ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B858CC", Offset = "0x1B858CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, global::System.Type returnType, global::System.Type[] types, ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85918", Offset = "0x1B85918", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85964", Offset = "0x1B85964", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B859B0", Offset = "0x1B859B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B859FC", Offset = "0x1B859FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85A48", Offset = "0x1B85A48", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85A94", Offset = "0x1B85A94", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, global::System.Type[] types, ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85AE0", Offset = "0x1B85AE0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsCOMObjectImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85B2C", Offset = "0x1B85B2C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsPrimitiveImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85B78", Offset = "0x1B85B78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsContextfulImpl()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60024BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85C10", Offset = "0x1B85C10", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsEquivalentTo(global::System.Type other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85C5C", Offset = "0x1B85C5C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsInstanceOfType(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85CA8", Offset = "0x1B85CA8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsMarshalByRefImpl()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60024C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85D40", Offset = "0x1B85D40", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override bool IsSubclassOf(global::System.Type c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60024C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B85D8C", Offset = "0x1B85D8C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected sealed override bool IsValueTypeImpl()
		{
			throw null;
		}

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
