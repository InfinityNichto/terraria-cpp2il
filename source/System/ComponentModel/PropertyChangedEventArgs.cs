using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002D1 RID: 721
	[global::Cpp2ILInjected.Token(Token = "0x20003D0")]
	public class PropertyChangedEventArgs : EventArgs
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x00007022 File Offset: 0x00005222
		[global::Cpp2ILInjected.Token(Token = "0x60019CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E603F0", Offset = "0x1E603F0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "OnPropertyChanged", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PropertyChangedEventArgs(string propertyName)
		{
			throw null;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00007025 File Offset: 0x00005225
		[global::Cpp2ILInjected.Token(Token = "0x170005E0")]
		public virtual string PropertyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6045C", Offset = "0x1E6045C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000EC0 RID: 3776
		[global::Cpp2ILInjected.Token(Token = "0x40012DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
