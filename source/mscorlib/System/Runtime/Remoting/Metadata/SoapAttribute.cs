using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Metadata
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200038D")]
	public class SoapAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F14", Offset = "0x1B42F14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SoapAttribute()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001D70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42F2C", Offset = "0x1B42F2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void SetReflectionObject(object reflectionObject)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000ECE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _useAttribute;

		[global::Cpp2ILInjected.Token(Token = "0x4000ECF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string ProtXmlNamespace;

		[global::Cpp2ILInjected.Token(Token = "0x4000ED0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected object ReflectInfo;
	}
}
