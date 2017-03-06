using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "c11d42d80f8866b2")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Feature</summary>
	[PublishedContentModel("umbFeature")]
	public partial class UmbFeature : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbFeature";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbFeature(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbFeature, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Feature Header
		///</summary>
		[ImplementPropertyType("featureHeader")]
		public string FeatureHeader
		{
			get { return this.GetPropertyValue<string>("featureHeader"); }
		}

		///<summary>
		/// Feature Text
		///</summary>
		[ImplementPropertyType("featureText")]
		public string FeatureText
		{
			get { return this.GetPropertyValue<string>("featureText"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}

		///<summary>
		/// Link: Link zur Poll Seite
		///</summary>
		[ImplementPropertyType("link")]
		public string Link
		{
			get { return this.GetPropertyValue<string>("link"); }
		}

		///<summary>
		/// Poll Description
		///</summary>
		[ImplementPropertyType("pollDescription")]
		public string PollDescription
		{
			get { return this.GetPropertyValue<string>("pollDescription"); }
		}

		///<summary>
		/// Poll Header
		///</summary>
		[ImplementPropertyType("pollHeader")]
		public string PollHeader
		{
			get { return this.GetPropertyValue<string>("pollHeader"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("umbHomePage")]
	public partial class UmbHomePage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Byline
		///</summary>
		[ImplementPropertyType("byline")]
		public string Byline
		{
			get { return this.GetPropertyValue<string>("byline"); }
		}

		///<summary>
		/// Closed Image
		///</summary>
		[ImplementPropertyType("closedImage")]
		public string ClosedImage
		{
			get { return this.GetPropertyValue<string>("closedImage"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Öffnungszeiten
		///</summary>
		[ImplementPropertyType("oeffnungszeiten")]
		public Diplo.DateRangePicker.DateRange Oeffnungszeiten
		{
			get { return this.GetPropertyValue<Diplo.DateRangePicker.DateRange>("oeffnungszeiten"); }
		}

		///<summary>
		/// Open Image
		///</summary>
		[ImplementPropertyType("openImage")]
		public string OpenImage
		{
			get { return this.GetPropertyValue<string>("openImage"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}
	}

	/// <summary>Kalender Item</summary>
	[PublishedContentModel("kalenderItem")]
	public partial class KalenderItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kalenderItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public KalenderItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<KalenderItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Beschreibung
		///</summary>
		[ImplementPropertyType("beschreibung")]
		public object Beschreibung
		{
			get { return this.GetPropertyValue("beschreibung"); }
		}

		///<summary>
		/// Ende Event
		///</summary>
		[ImplementPropertyType("endeEvent")]
		public DateTime EndeEvent
		{
			get { return this.GetPropertyValue<DateTime>("endeEvent"); }
		}

		///<summary>
		/// Start Event
		///</summary>
		[ImplementPropertyType("startEvent")]
		public DateTime StartEvent
		{
			get { return this.GetPropertyValue<DateTime>("startEvent"); }
		}

		///<summary>
		/// Überschrift
		///</summary>
		[ImplementPropertyType("uberschrift")]
		public string Uberschrift
		{
			get { return this.GetPropertyValue<string>("uberschrift"); }
		}

		///<summary>
		/// Verstecken?
		///</summary>
		[ImplementPropertyType("verstecken")]
		public object Verstecken
		{
			get { return this.GetPropertyValue("verstecken"); }
		}
	}

	/// <summary>Kalender Repository</summary>
	[PublishedContentModel("kalenderRepository")]
	public partial class KalenderRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kalenderRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public KalenderRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<KalenderRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Byline
		///</summary>
		[ImplementPropertyType("byline")]
		public string Byline
		{
			get { return this.GetPropertyValue<string>("byline"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Items per page
		///</summary>
		[ImplementPropertyType("itemsPerPage")]
		public int ItemsPerPage
		{
			get { return this.GetPropertyValue<int>("itemsPerPage"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}
	}

	/// <summary>News Repository</summary>
	[PublishedContentModel("newsRepository")]
	public partial class NewsRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "newsRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NewsRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Byline
		///</summary>
		[ImplementPropertyType("byline")]
		public string Byline
		{
			get { return this.GetPropertyValue<string>("byline"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Items per page
		///</summary>
		[ImplementPropertyType("itemsPerPage")]
		public int ItemsPerPage
		{
			get { return this.GetPropertyValue<int>("itemsPerPage"); }
		}

		///<summary>
		/// SiteName
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}
	}

	/// <summary>News Item</summary>
	[PublishedContentModel("newsItem")]
	public partial class NewsItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "newsItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NewsItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Inhalt
		///</summary>
		[ImplementPropertyType("inhalt")]
		public object Inhalt
		{
			get { return this.GetPropertyValue("inhalt"); }
		}

		///<summary>
		/// Überschrift
		///</summary>
		[ImplementPropertyType("uberschrift")]
		public string Uberschrift
		{
			get { return this.GetPropertyValue<string>("uberschrift"); }
		}

		///<summary>
		/// Verstecken
		///</summary>
		[ImplementPropertyType("verstecken")]
		public object Verstecken
		{
			get { return this.GetPropertyValue("verstecken"); }
		}
	}

	/// <summary>Login</summary>
	[PublishedContentModel("login")]
	public partial class Login : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "login";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Login(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Login, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Begrüßung
		///</summary>
		[ImplementPropertyType("begruessung")]
		public string Begruessung
		{
			get { return this.GetPropertyValue<string>("begruessung"); }
		}

		///<summary>
		/// Verstecken?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
