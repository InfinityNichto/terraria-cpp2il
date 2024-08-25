using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.ComponentModel
{
	[ComVisible(true)]
	[TypeConverter(typeof(ComponentConverter))]
	[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003E3")]
	public interface IComponent : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700060A")]
		ISite Site
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A4E")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001A4F")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400001A")]
		event EventHandler Disposed;
	}
}
