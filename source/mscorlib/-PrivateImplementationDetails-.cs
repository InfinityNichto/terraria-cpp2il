﻿using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;
using Mono.Xml;

[global::System.Runtime.CompilerServices.CompilerGenerated]
[global::Cpp2ILInjected.Token(Token = "0x200066D")]
internal sealed class <PrivateImplementationDetails>
{
	[global::Cpp2ILInjected.Token(Token = "0x60031EC")]
	[global::Cpp2ILInjected.Address(RVA = "0x1C13D34", Offset = "0x1C13D34", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
	{
		typeof(global::System.Runtime.Serialization.SerializationInfo),
		typeof(global::System.Runtime.Serialization.StreamingContext),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ParseElement", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Mono.Xml.SmallXmlParser.IAttrList)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "InitMethodProperty", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MessageDictionary), Member = "GetMethodProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MessageDictionary), Member = "SetMethodProperty", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = "InitMethodProperty", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Globalization.CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	internal static uint ComputeStringHash(string s)
	{
		throw null;
	}

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC0")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed125 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC1")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed135 021022D5891F99B3B525763EB77BAEC69B107268F560721F5060FCDBD4D5AAE8;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC2")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 042957A0DB5FF2D38A343AC5AE5F8635B88F10C32EB87A238B1DFB4756468476;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC3")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed124 07FA6E88C946B2528C09C16C2FB8E9CDA49AFFAFC601774C437FD9F2DF3ECE01;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC4")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed129 0C496C9AE05419BD25256D0EF4F31AFD291119F14B8BD683BF1774F91E08659D;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC5")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 0E499E7743BCDFF289B85890E4DFDD635594DB16246DC094C3C19556B6C1262C;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC6")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 0F9E3C7E66CDEF5C44FA29E65CA676C480F7A2A4A067F70107FDC292C68D38B0;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC7")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed127 1199C3B39A2FA058EFF5B3829616AE81EE2B59A51D89C107A5FA4B6FEF95DD16;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC8")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed145 125CF2084D7EEC18DC9795BE4BAA221655C0EABAB89E90A74FB0370378A60293;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AC9")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed158 12D518BA10F3DD1A331E65FBD4C330930C0A0BD9F50F37BE0BDF596E964B9A78;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ACA")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed132 195ABC1ABB69B6BD65F20ACAFA79EED2D330BF513E25C830F24B8A78D8703446;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ACB")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed110 1A07BC77B9912D8D87E9B28E0167F53A9B09BB017B35A35F3913989C9440A60B;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ACC")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed153 1B9CC34A0CF8DBCC350E200673FAC4124DDAD581F1FC2C16FF9A1C0154691687;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ACD")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed144 1C4B3A80ED7AEC83916479BCE280E1258D5785D07F0EA22A5E27592ACCAE692B;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ACE")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed120 1F38DEB3F70291588D06D3830D0D4241CE0570C9F4EE8B00F606C4753EB016E2;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ACF")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed110 215E3E0B11A214B3198654E87B3D953AC8FB1ABC7045AF841A7C4892624BDE49;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD0")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 2403FBEA85D0741C5727760E97EF16C9BF23294F21C0F1265A4BAF7F22202A64;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD1")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed113 24CB9F17C8326D8BB8EC908716519DF7F265AE825F0DD13BB04E03A90B07D90E;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD2")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed127 25308BAB47481701F1E861B1EA4F2409E73ABB14E9579C26DF4ABE440A0DCF0A;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD3")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed162 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD4")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed108 2AC9A6746ACA543AF8DFF39894CFE8173AFBA21EB01C6FAE33D52947222855EF;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD5")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 2CCF4119215BDAD102DA7AD5B57E0E6CA19CC8FF5524856FC58907E824213E1F;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD6")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 3444EB31231B2CCC1B05C7A44EBD1B2A009C1D9977A99B453F52E2F81DD6C32F;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD7")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed113 3D95E4501B1964D7FCE16E3F5682A038752B462357D87343880B1E819F6163FE;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD8")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 3F62692E2AD5078353EC4471A13421A61EE493294CF59DC66626A6EF9CCCD2C4;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AD9")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 42E1421FC2A5A6A33E964D7EB9603EB101818D858DDA09B2BC9B5A888C1C351C;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ADA")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed109 44D066BAE9848B4A4B2C31F1854666526A32D0588635569423BDA1DA303C97DF;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ADB")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed131 4623CA5867960AA898AA1F65E720CD5ECD3552542E0C6F6FB65B21D14DD1CBC2;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ADC")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed122 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ADD")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed163 493402F3E4397B2945B16273E795816C0BDF80F76F42FCAA75F3DF2E215ABC1B;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ADE")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed137 494C32E1A18F6E8AD8ED5FAB0A5AF07F801BE7AF3C936942B020918CE2953046;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001ADF")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed161 4E0B9E024FA510B6F03C92D95BB204E78CDC6E3FD2EC8D35787B7BC76F0655A0;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE0")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed121 508085E0DDEEA9CE48BFAE98CEC779F8D06301AE973555D37680D08190CAFA70;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE1")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 510FDFA4743E58DD45DCDD7CB4F8509BF6294CC1D1D4958CA30A9E7604973006;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE2")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed120 5292FD0A8E62FCCBE41F34EFE7575D097990A66FE23B3507971C5BF272A4362E;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE3")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed114 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE4")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed123 543172FF9822CE5240DF89FF3AD8C7FD9824F97D0EED9B1432E60345FBBDE9A9;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE5")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE6")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed165 56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE7")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed123 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE8")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed116 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AE9")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 5EC4E50DA95A113769D73E5F7F8221A876185CEE6498ABB16FBB9F0563C15BBF;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AEA")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed130 61D639BE11384EE21CDE2B40357F4F9D80A106C97C592D18A9F4CAA442CA5D31;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AEB")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AEC")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed157 668BB69E184E0C32DC3BC488001C506C87EE5A95C7E7B6B87D24C3A6DC779956;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AED")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed122 6708B572BDBE5D5E79701DBB9744AF74B50FED7608218F2D7BF1B5D87E5A53ED;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AEE")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed146 67856A16DB0550FDAB4D1A9B208B0C155C4679CA116BF867B74ED2A0AA4D2955;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AEF")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed152 692DE452EE427272A5F6154F04360D24165B56693B08F60D93127DEDC12D1DDE;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF0")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed128 6DABE7D1BCE5A165B668653474D7F5F3680A7FBC30EA3F3FC3FEB1790BD659B5;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF1")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 6DC92D3617F0357376502FBA4CDD465B5423818DABE8B2CA1A06E1351F2F1C85;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF2")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed138 71F7F6B226CBC11C8B26D506869FAE022928427389882579DB316F36FF34A096;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF3")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed157 73F5D95C401726B2C92EC96A696BA15F0E5A5C6DD9AC6BEB3736A81772A11531;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF4")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed142 74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B20;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF5")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 74EF7306E7452D6859B6463CE496B8DF30925F69E1B2969E1F3F34BBC9C6AF04;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF6")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed147 765BD07ED3CB498A599FFB48B31E077C45B4C2C37CD1547CEA27E60655CF21B6;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF7")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed131 78AD7906208AA1E531D0C1100062DE3D252210B1E4214061294A0BB7C94762B8;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF8")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed154 7BEC6AD454781FDCD8D475B3418629CBABB3BF9CA66FA80009D608A1A60D0696;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AF9")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 7F777906B0704EB248888E491577584D5BEBE71B375BD595A06444390B471915;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AFA")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 801494072CDD59E61F9AA9345A80D045378705DFDCE94902C22EAEAE049BE780;

	// Note: this field is marked with 'hasfieldrva' and has an initial value of '85899345920'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AFB")]
	internal static readonly long 819B40F8CF7DC49B4275955A17C10239F1BBBB3BF96E26E25ED844B96B645D7F;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AFC")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 8259E3EBA4D41CA02AE5322BBD280034A9C9860D9CD0D2038139FC9EBE6B6C77;

	// Note: this field is marked with 'hasfieldrva' and has an initial value of '128849018900'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AFD")]
	internal static readonly long 82B100804CE219CD73E155C7C6457FCF04EA539DE5B19F4736E800098714EB21;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AFE")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 861FD05B0EAD3D0AA9418B140CC37846BBC5F195214D90CEF42919D1E36EED10;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001AFF")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed148 86BDA34D2165AC08F2DE4918B302E44205CDEA674FCA7F2C7F56D4F12D8B0C73;

	// Note: this field is marked with 'hasfieldrva' and has an initial value of '4503724182733082'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B00")]
	internal static readonly long 8BFD94DEAAC0F168DC8B50A00AC120A113B550B68FEF344F807D503D1A6E5DED;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B01")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed155 8CCE27079B32C13BB310169A6AD26AE419CDC98B7E2EFD3CC9997257F4BC1DEF;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B02")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed164 9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B03")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed143 93B42898102ACB2421875C45676880B8A07390D8DF0E1EE85C5D1AA26964B0C6;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B04")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed123 93F28AF88A06482BE13F8D0354B6A7676DDAED573EA3938C50F6E53E6D6BB0B6;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B05")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed137 95BDE712712F10D07813AE3DEEA40D1F38E3FCF1A92CC435F17A326CC22242EB;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B06")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed141 964889A5283FD0A3DFC8AE256721E6F67B8212FD6841AB1C821DE3134DE79B07;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B07")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed112 96E3FDE919EC36694EFBEC22FEF80F84EE640CC5E46CED07C3E65AC04607C7D6;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B08")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed117 9960C7FC60CDD325C8A2A00995BE7064EAC3F6295C6A5C4E797D2281846131E4;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B09")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed121 99E66DACA3EFF94776AF1258E0E5B2F4DF2900E4EA32351B0DF37A87F2426B1F;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B0A")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 A252A93D042C5E2453990C2829A425C6DD749CCDCDF13DB58C11BBC78E8D3CE9;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B0B")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed131 A2DFDF9C2CED8BB1C0B9B06064345ACC9C22DFE5FEC9976FF061F0994451519B;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B0C")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed127 A2EC7CB9B0FE89F9A9BEA547D773225AFE6E4535DF28325A0D6CD7A5E2D20376;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B0D")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 A30E1152CFB528AE968FAC58E83BBEB3611BFDE2E6CF60B4FA9535A7D0A9B8EA;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B0E")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed119 A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A2;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B0F")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 AAF4528994DD7C464F43C131F6CD44DF41ACC18462C95877252FFC7EAC0164EF;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B10")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed156 AB0B9733AAEC4A2806711E41E36D3D0923BAF116156F33445DC2AA58DA5DF877;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B11")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed163 B215DD70A77190680641703C6DF73729B4583E285AF8B51ACF9086655FB2D0F3;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B12")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed123 B21802DE889E5F4F5344C8E0D366F59B68F886F88EFE45EA5CE01534A3F5C0E5;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B13")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed159 B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B14")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed117 BABD01C34E7E65E57E4C431281E782B4101CE0644A8090AD6E501F1C6CF2C9DF;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B15")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed113 BB425A9B43E10C921902A25D07A4317DEFF9F606A788672E1B21633C143407F0;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B16")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed117 C250CAD28060A4EB63B4C4A643DDA196CCD35FD2FC67FB749ADF4BAC6D62E1A0;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B17")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 C2D8E5EED6CBEBD8625FC18F81486A7733C04F9B0129FFBE974C68B90308B4F2;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B18")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 C5733A1245383FBF067B4A9BDB41E3FB8E3A6BDEF37B3D5418F389422875783F;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B19")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed150 C8EC70AC5A448C3A45CF1DFCC1375BE4E80DC6793E97D5E89BD97A0DC232B2E3;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B1A")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed113 C95D810E738DB5F591EE691CE884EED2F110D9F82B1F7A8BE6ED257FDF4CDBEB;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B1B")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed133 C9830DF6956357ACE51CE1F82298578B36EB45A0CFDB8AEC5B9FDA7DB17E8063;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B1C")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 CAF8A46B3A07E26F84FE849B57A877051A0D06194B1C057985446B64BCC6E016;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B1D")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed117 CAFFFC9D15E4037EE8FBDB1A45DFE456F0936BDC7310F1882EAF14B706A76658;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B1E")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed163 CE11D6DEAFFC6D6EF6030E30E7444C933E6261F32AA737064EF0446C219ECE22;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B1F")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 D1A99909A2923269BB67E72C1AED693F74961BDA58360FCC133007740CEBF5F1;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B20")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed109 D3B16F8D71CB719B941527D5A1ADA7ED83F4EB967FEE117DDA2FE4021E1D283F;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B21")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 D503954AE2C3616EA32CEB0D66F5B2E119D03CE722773E5D7E1A8BC8F1803631;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B22")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed136 D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B23")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed157 D870074914025E855AA5985A2D6778F1E277036BF9C9F03DEC61F3C496FEC35C;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B24")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 D896D464C3726A21162F271ACB711464AD07EA9C9CE78E0297FD0DE934471FA6;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B25")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 D8A29F3D197FBB54CF9F4B105AFBA6B1257ADF6449F0184F843380AAAA24639C;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B26")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 DCDCF594464B904F763D4CE53B1DBE08A47E551AE86FD5D61F63FD0C3313FDC3;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B27")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed160 DCE88EE5233B9D0FD0D7A6222C82BC3AEE83B15E9992F939B17AB40530DB555C;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B28")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed134 DD471F12FFA94CC557A02A91C2CBB95F551AB28C8BBF297B2F953B8886BCCF6D;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B29")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 DF29A050CD2EBD9DFDC783DB1CC74D3D716DAEC1630A337EE31B9E2E03D34D2D;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B2A")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed163 E148B2057CF0C1595155635E761FB66AAE634C40D8FABC4CE79A2DB8886525D4;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B2B")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed118 E2C673A3A737B04369A63F1FB1A30F6E742B066E2CCCD9B1838793CBB5590598;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B2C")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 E32C465157D21F39B3DBF186A98FB02185C63B0260B47247A7A5FDF2B061EAA8;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B2D")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed115 E5F4F6214036DF103321A8A0CE30C2EF935694B4199D52BC538E7EF3F045CB92;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B2E")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed125 E768EDCAE10BAB68BB5DF102FDBB8CF4F31B9D60159B44DA3F33ABC36388308B;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B2F")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed149 E8588351183F6F6A7DAD54DC28357628F3C4D4B358AB92A18AE7D08B0D9B0092;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B30")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed111 EBE07C3718876777F609CD22058F4C3A6CCCC695F5BDE90998DC1E12E0CBE63D;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B31")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed116 EE415D5C3ECC6C8C19F71BCD4E03847F5A15931374A7F5BF88C24B722F04B8FE;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B32")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 EF39C5A882F9477B2A250BA257247825CEB07FC53C3C984385F2C2E5F8222431;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B33")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed113 EF82B163CA8252A793A6E73F57775D843C9A21F65586926EB11893FA8BB603E9;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B34")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed139 F0CF66F9B123DCEBB39C38C5D8E4821D4E94DB593889C506BCA0827036F1B7EB;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B35")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed108 F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B36")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed140 F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B37")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed126 F4BD8144313C3B67E191C6F3CD8B00540FF1809837C5BCA5C2FDA0D518681563;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B38")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed150 F7D2AD02ED768134B31339AB059D864789E0A60090CC368B3881EB0631BBAF93;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B39")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed138 F7D381AF73D85950E0B064CF1AA8F14938A1F38084B46CE36AAEFE81BEF739F3;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B3A")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed123 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B3B")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed151 FB2089AF82E09593374B65EC2440779FDCF5DD6DA07D26E57AF6790667B937CD;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B3C")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed139 FD68700E95459C5E7A49C5830F8BD0A9BA4BD171252663D8066B09E7768C5C5D;

	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001B3D")]
	internal static readonly global::<PrivateImplementationDetails>.ValueTypeNPrivateSealed115 FEC387BA57A54BB6066E4CA8A4F9C0FF9C36B9CBD6600C3683F6FB1BDB5077EB;

	[global::Cpp2ILInjected.Token(Token = "0x200066E")]
	[StructLayout(2, Pack = 1, Size = 3)]
	private struct ValueTypeNPrivateSealed108
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200066F")]
	[StructLayout(2, Pack = 1, Size = 6)]
	private struct ValueTypeNPrivateSealed109
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000670")]
	[StructLayout(2, Pack = 1, Size = 10)]
	private struct ValueTypeNPrivateSealed110
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000671")]
	[StructLayout(2, Pack = 1, Size = 12)]
	private struct ValueTypeNPrivateSealed111
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000672")]
	[StructLayout(2, Pack = 1, Size = 15)]
	private struct ValueTypeNPrivateSealed112
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000673")]
	[StructLayout(2, Pack = 1, Size = 16)]
	private struct ValueTypeNPrivateSealed113
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000674")]
	[StructLayout(2, Pack = 1, Size = 20)]
	private struct ValueTypeNPrivateSealed114
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000675")]
	[StructLayout(2, Pack = 1, Size = 24)]
	private struct ValueTypeNPrivateSealed115
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000676")]
	[StructLayout(2, Pack = 1, Size = 32)]
	private struct ValueTypeNPrivateSealed116
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000677")]
	[StructLayout(2, Pack = 1, Size = 36)]
	private struct ValueTypeNPrivateSealed117
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000678")]
	[StructLayout(2, Pack = 1, Size = 38)]
	private struct ValueTypeNPrivateSealed118
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000679")]
	[StructLayout(2, Pack = 1, Size = 40)]
	private struct ValueTypeNPrivateSealed119
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200067A")]
	[StructLayout(2, Pack = 1, Size = 42)]
	private struct ValueTypeNPrivateSealed120
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200067B")]
	[StructLayout(2, Pack = 1, Size = 44)]
	private struct ValueTypeNPrivateSealed121
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200067C")]
	[StructLayout(2, Pack = 1, Size = 48)]
	private struct ValueTypeNPrivateSealed122
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200067D")]
	[StructLayout(2, Pack = 1, Size = 52)]
	private struct ValueTypeNPrivateSealed123
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200067E")]
	[StructLayout(2, Pack = 1, Size = 56)]
	private struct ValueTypeNPrivateSealed124
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200067F")]
	[StructLayout(2, Pack = 1, Size = 64)]
	private struct ValueTypeNPrivateSealed125
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000680")]
	[StructLayout(2, Pack = 1, Size = 72)]
	private struct ValueTypeNPrivateSealed126
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000681")]
	[StructLayout(2, Pack = 1, Size = 76)]
	private struct ValueTypeNPrivateSealed127
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000682")]
	[StructLayout(2, Pack = 1, Size = 82)]
	private struct ValueTypeNPrivateSealed128
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000683")]
	[StructLayout(2, Pack = 1, Size = 84)]
	private struct ValueTypeNPrivateSealed129
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000684")]
	[StructLayout(2, Pack = 1, Size = 94)]
	private struct ValueTypeNPrivateSealed130
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000685")]
	[StructLayout(2, Pack = 1, Size = 120)]
	private struct ValueTypeNPrivateSealed131
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000686")]
	[StructLayout(2, Pack = 1, Size = 128)]
	private struct ValueTypeNPrivateSealed132
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000687")]
	[StructLayout(2, Pack = 1, Size = 130)]
	private struct ValueTypeNPrivateSealed133
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000688")]
	[StructLayout(2, Pack = 1, Size = 152)]
	private struct ValueTypeNPrivateSealed134
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000689")]
	[StructLayout(2, Pack = 1, Size = 170)]
	private struct ValueTypeNPrivateSealed135
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200068A")]
	[StructLayout(2, Pack = 1, Size = 172)]
	private struct ValueTypeNPrivateSealed136
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200068B")]
	[StructLayout(2, Pack = 1, Size = 174)]
	private struct ValueTypeNPrivateSealed137
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200068C")]
	[StructLayout(2, Pack = 1, Size = 212)]
	private struct ValueTypeNPrivateSealed138
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200068D")]
	[StructLayout(2, Pack = 1, Size = 240)]
	private struct ValueTypeNPrivateSealed139
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200068E")]
	[StructLayout(2, Pack = 1, Size = 256)]
	private struct ValueTypeNPrivateSealed140
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200068F")]
	[StructLayout(2, Pack = 1, Size = 262)]
	private struct ValueTypeNPrivateSealed141
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000690")]
	[StructLayout(2, Pack = 1, Size = 288)]
	private struct ValueTypeNPrivateSealed142
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000691")]
	[StructLayout(2, Pack = 1, Size = 336)]
	private struct ValueTypeNPrivateSealed143
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000692")]
	[StructLayout(2, Pack = 1, Size = 360)]
	private struct ValueTypeNPrivateSealed144
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000693")]
	[StructLayout(2, Pack = 1, Size = 640)]
	private struct ValueTypeNPrivateSealed145
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000694")]
	[StructLayout(2, Pack = 1, Size = 648)]
	private struct ValueTypeNPrivateSealed146
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000695")]
	[StructLayout(2, Pack = 1, Size = 761)]
	private struct ValueTypeNPrivateSealed147
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000696")]
	[StructLayout(2, Pack = 1, Size = 998)]
	private struct ValueTypeNPrivateSealed148
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000697")]
	[StructLayout(2, Pack = 1, Size = 1018)]
	private struct ValueTypeNPrivateSealed149
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000698")]
	[StructLayout(2, Pack = 1, Size = 1024)]
	private struct ValueTypeNPrivateSealed150
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000699")]
	[StructLayout(2, Pack = 1, Size = 1208)]
	private struct ValueTypeNPrivateSealed151
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200069A")]
	[StructLayout(2, Pack = 1, Size = 1320)]
	private struct ValueTypeNPrivateSealed152
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200069B")]
	[StructLayout(2, Pack = 1, Size = 1450)]
	private struct ValueTypeNPrivateSealed153
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200069C")]
	[StructLayout(2, Pack = 1, Size = 1472)]
	private struct ValueTypeNPrivateSealed154
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200069D")]
	[StructLayout(2, Pack = 1, Size = 1665)]
	private struct ValueTypeNPrivateSealed155
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200069E")]
	[StructLayout(2, Pack = 1, Size = 1824)]
	private struct ValueTypeNPrivateSealed156
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x200069F")]
	[StructLayout(2, Pack = 1, Size = 2048)]
	private struct ValueTypeNPrivateSealed157
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A0")]
	[StructLayout(2, Pack = 1, Size = 2100)]
	private struct ValueTypeNPrivateSealed158
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A1")]
	[StructLayout(2, Pack = 1, Size = 2176)]
	private struct ValueTypeNPrivateSealed159
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A2")]
	[StructLayout(2, Pack = 1, Size = 2350)]
	private struct ValueTypeNPrivateSealed160
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A3")]
	[StructLayout(2, Pack = 1, Size = 2382)]
	private struct ValueTypeNPrivateSealed161
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A4")]
	[StructLayout(2, Pack = 1, Size = 3132)]
	private struct ValueTypeNPrivateSealed162
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A5")]
	[StructLayout(2, Pack = 1, Size = 4096)]
	private struct ValueTypeNPrivateSealed163
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A6")]
	[StructLayout(2, Pack = 1, Size = 5952)]
	private struct ValueTypeNPrivateSealed164
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x20006A7")]
	[StructLayout(2, Pack = 1, Size = 10800)]
	private struct ValueTypeNPrivateSealed165
	{
	}
}
