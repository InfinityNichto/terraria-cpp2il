using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002D3 RID: 723
	[global::Cpp2ILInjected.Token(Token = "0x20003D2")]
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x06001772 RID: 6002 RVA: 0x00007028 File Offset: 0x00005228
		[global::Cpp2ILInjected.Token(Token = "0x60019D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E605DC", Offset = "0x1E605DC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PropertyChangingEventArgs(string propertyName)
		{
			throw null;
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0000702B File Offset: 0x0000522B
		[global::Cpp2ILInjected.Token(Token = "0x170005E1")]
		public virtual string PropertyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E60648", Offset = "0x1E60648", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000EC1 RID: 3777
		[global::Cpp2ILInjected.Token(Token = "0x40012DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
