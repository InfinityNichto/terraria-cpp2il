using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020002E9 RID: 745
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200038D")]
	public class SoapAttribute : global::System.Attribute
	{
		// Token: 0x06001B40 RID: 6976 RVA: 0x00019142 File Offset: 0x00017342
		[global::Cpp2ILInjected.Token(Token = "0x6001D6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F14", Offset = "0x1B42F14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapAttribute()
		{
			throw null;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00019145 File Offset: 0x00017345
		[global::Cpp2ILInjected.Token(Token = "0x17000382")]
		public virtual bool UseAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42F1C", Offset = "0x1B42F1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00019148 File Offset: 0x00017348
		[global::Cpp2ILInjected.Token(Token = "0x17000383")]
		public virtual string XmlNamespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B42F24", Offset = "0x1B42F24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0001914B File Offset: 0x0001734B
		[global::Cpp2ILInjected.Token(Token = "0x6001D70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F2C", Offset = "0x1B42F2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void SetReflectionObject(object reflectionObject)
		{
			throw null;
		}

		// Token: 0x04000BE3 RID: 3043
		[global::Cpp2ILInjected.Token(Token = "0x4000ECE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _useAttribute;

		// Token: 0x04000BE4 RID: 3044
		[global::Cpp2ILInjected.Token(Token = "0x4000ECF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string ProtXmlNamespace;

		// Token: 0x04000BE5 RID: 3045
		[global::Cpp2ILInjected.Token(Token = "0x4000ED0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected object ReflectInfo;
	}
}
