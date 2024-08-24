using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000689 RID: 1673
	[global::Cpp2ILInjected.Token(Token = "0x2000A33")]
	public interface ICreativePower
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060041AA RID: 16810
		// (set) Token: 0x060041AB RID: 16811
		[global::Cpp2ILInjected.Token(Token = "0x17000877")]
		ushort PowerId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C9C")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004C9D")]
			set;
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060041AC RID: 16812
		// (set) Token: 0x060041AD RID: 16813
		[global::Cpp2ILInjected.Token(Token = "0x17000878")]
		string ServerConfigName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C9E")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004C9F")]
			set;
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060041AE RID: 16814
		// (set) Token: 0x060041AF RID: 16815
		[global::Cpp2ILInjected.Token(Token = "0x17000879")]
		PowerPermissionLevel CurrentPermissionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004CA0")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004CA1")]
			set;
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060041B0 RID: 16816
		// (set) Token: 0x060041B1 RID: 16817
		[global::Cpp2ILInjected.Token(Token = "0x1700087A")]
		PowerPermissionLevel DefaultPermissionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004CA2")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6004CA3")]
			set;
		}

		// Token: 0x060041B2 RID: 16818
		[global::Cpp2ILInjected.Token(Token = "0x6004CA4")]
		void DeserializeNetMessage(BinaryReader reader, int userId);

		// Token: 0x060041B3 RID: 16819
		[global::Cpp2ILInjected.Token(Token = "0x6004CA5")]
		void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements);

		// Token: 0x060041B4 RID: 16820
		[global::Cpp2ILInjected.Token(Token = "0x6004CA6")]
		bool GetIsUnlocked();
	}
}
