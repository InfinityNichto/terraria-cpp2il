using System;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x02000292 RID: 658
	[global::Cpp2ILInjected.Token(Token = "0x2000389")]
	public interface ITypeDescriptorContext : IServiceProvider
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001557 RID: 5463
		[global::Cpp2ILInjected.Token(Token = "0x17000564")]
		IContainer Container
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A2")]
			get;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001558 RID: 5464
		[global::Cpp2ILInjected.Token(Token = "0x17000565")]
		object Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A3")]
			get;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001559 RID: 5465
		[global::Cpp2ILInjected.Token(Token = "0x17000566")]
		PropertyDescriptor PropertyDescriptor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017A4")]
			get;
		}

		// Token: 0x0600155A RID: 5466
		[global::Cpp2ILInjected.Token(Token = "0x60017A5")]
		bool OnComponentChanging();

		// Token: 0x0600155B RID: 5467
		[global::Cpp2ILInjected.Token(Token = "0x60017A6")]
		void OnComponentChanged();
	}
}
