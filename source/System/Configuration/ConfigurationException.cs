using System;
using System.Runtime.Serialization;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x0200031D RID: 797
	[global::Cpp2ILInjected.Token(Token = "0x2000451")]
	[Serializable]
	public class ConfigurationException : SystemException
	{
		// Token: 0x06001A9C RID: 6812 RVA: 0x00007922 File Offset: 0x00005B22
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E967CC", Offset = "0x1E967CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException()
		{
			throw null;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00007925 File Offset: 0x00005B25
		[global::Cpp2ILInjected.Token(Token = "0x6001DF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96804", Offset = "0x1E96804", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected ConfigurationException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00007928 File Offset: 0x00005B28
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9683C", Offset = "0x1E9683C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException(string message)
		{
			throw null;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0000792B File Offset: 0x00005B2B
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96874", Offset = "0x1E96874", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException(string message, Exception inner)
		{
			throw null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000792E File Offset: 0x00005B2E
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E968AC", Offset = "0x1E968AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException(string message, Exception inner, string filename, int line)
		{
			throw null;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00007931 File Offset: 0x00005B31
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E968E4", Offset = "0x1E968E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException(string message, Exception inner, XmlNode node)
		{
			throw null;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00007934 File Offset: 0x00005B34
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9691C", Offset = "0x1E9691C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException(string message, string filename, int line)
		{
			throw null;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00007937 File Offset: 0x00005B37
		[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
		[global::Cpp2ILInjected.Token(Token = "0x6001DFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96954", Offset = "0x1E96954", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConfigurationException(string message, XmlNode node)
		{
			throw null;
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0000793A File Offset: 0x00005B3A
		[global::Cpp2ILInjected.Token(Token = "0x170006BC")]
		public virtual string BareMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9698C", Offset = "0x1E9698C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0000793D File Offset: 0x00005B3D
		[global::Cpp2ILInjected.Token(Token = "0x170006BD")]
		public virtual string Filename
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E969C4", Offset = "0x1E969C4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00007940 File Offset: 0x00005B40
		[global::Cpp2ILInjected.Token(Token = "0x170006BE")]
		public virtual int Line
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E969FC", Offset = "0x1E969FC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00007943 File Offset: 0x00005B43
		[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetFilename instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6001E00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96A34", Offset = "0x1E96A34", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetXmlNodeFilename(XmlNode node)
		{
			throw null;
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00007946 File Offset: 0x00005B46
		[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetLinenumber instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6001E01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96A6C", Offset = "0x1E96A6C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int GetXmlNodeLineNumber(XmlNode node)
		{
			throw null;
		}
	}
}
