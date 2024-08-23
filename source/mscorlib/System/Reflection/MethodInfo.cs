using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000420 RID: 1056
	[global::Cpp2ILInjected.Token(Token = "0x20004DF")]
	[global::System.Serializable]
	public abstract class MethodInfo : MethodBase
	{
		// Token: 0x0600214A RID: 8522 RVA: 0x0001A201 File Offset: 0x00018401
		[global::Cpp2ILInjected.Token(Token = "0x60023E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82F14", Offset = "0x1B82F14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MethodInfo()
		{
			throw null;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x0001A204 File Offset: 0x00018404
		[global::Cpp2ILInjected.Token(Token = "0x170004BC")]
		public override MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B82F1C", Offset = "0x1B82F1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x0001A207 File Offset: 0x00018407
		[global::Cpp2ILInjected.Token(Token = "0x170004BD")]
		public virtual ParameterInfo ReturnParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B82F24", Offset = "0x1B82F24", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0001A20A File Offset: 0x0001840A
		[global::Cpp2ILInjected.Token(Token = "0x170004BE")]
		public virtual global::System.Type ReturnType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B82F4C", Offset = "0x1B82F4C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0001A20D File Offset: 0x0001840D
		[global::Cpp2ILInjected.Token(Token = "0x60023E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82F74", Offset = "0x1B82F74", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0001A210 File Offset: 0x00018410
		[global::Cpp2ILInjected.Token(Token = "0x60023E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82FC0", Offset = "0x1B82FC0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual MethodInfo GetGenericMethodDefinition()
		{
			throw null;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0001A213 File Offset: 0x00018413
		[global::Cpp2ILInjected.Token(Token = "0x60023EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8300C", Offset = "0x1B8300C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual MethodInfo MakeGenericMethod(params global::System.Type[] typeArguments)
		{
			throw null;
		}

		// Token: 0x06002151 RID: 8529
		[global::Cpp2ILInjected.Token(Token = "0x60023EB")]
		public abstract MethodInfo GetBaseDefinition();

		// Token: 0x06002152 RID: 8530 RVA: 0x0001A216 File Offset: 0x00018416
		[global::Cpp2ILInjected.Token(Token = "0x60023EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83058", Offset = "0x1B83058", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Delegate CreateDelegate(global::System.Type delegateType, object target)
		{
			throw null;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0001A219 File Offset: 0x00018419
		[global::Cpp2ILInjected.Token(Token = "0x60023ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B830A4", Offset = "0x1B830A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0001A21C File Offset: 0x0001841C
		[global::Cpp2ILInjected.Token(Token = "0x60023EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B830AC", Offset = "0x1B830AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0001A21F File Offset: 0x0001841F
		[global::Cpp2ILInjected.Token(Token = "0x60023EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B828F0", Offset = "0x1B828F0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(MethodInfo left, MethodInfo right)
		{
			throw null;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0001A222 File Offset: 0x00018422
		[global::Cpp2ILInjected.Token(Token = "0x60023F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B828B4", Offset = "0x1B828B4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 55)]
		public static bool operator !=(MethodInfo left, MethodInfo right)
		{
			throw null;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x0001A225 File Offset: 0x00018425
		[global::Cpp2ILInjected.Token(Token = "0x170004BF")]
		internal virtual int GenericParameterCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B830B4", Offset = "0x1B830B4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
