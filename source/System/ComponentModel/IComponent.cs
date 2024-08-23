using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	// Token: 0x020002E3 RID: 739
	[ComVisible(true)]
	[TypeConverter(typeof(ComponentConverter))]
	[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003E3")]
	public interface IComponent : IDisposable
	{
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060017E5 RID: 6117
		// (set) Token: 0x060017E6 RID: 6118
		[global::Cpp2ILInjected.Token(Token = "0x1700060A")]
		ISite Site
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A4E")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001A4F")]
			set;
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060017E7 RID: 6119
		// (remove) Token: 0x060017E8 RID: 6120
		[global::Cpp2ILInjected.Token(Token = "0x1400001A")]
		event EventHandler Disposed;
	}
}
