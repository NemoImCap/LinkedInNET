﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// XML document found at '\src\NET35.Sparkle.LinkedInNET\..\LinkedInApi.xml'
// return types: '0'
// API groups: '4'

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'person'
    /// </summary>
    [Serializable, XmlRoot("person")]
    public class Person
    {
        /// <summary>
        /// Field: 'first-name' (default)
        /// </summary>
        [XmlElement(ElementName = "first-name")]
        public string Firstname { get; set; }

        /// <summary>
        /// Field: 'last-name' (default)
        /// </summary>
        [XmlElement(ElementName = "last-name")]
        public string Lastname { get; set; }

        /// <summary>
        /// Field: 'headline' (default)
        /// Field: 'headline' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "headline")]
        public string Headline { get; set; }

        /// <summary>
        /// Field: 'site-standard-profile-request/url' (default)
        /// </summary>
        [XmlElement(ElementName = "site-standard-profile-request/url")]
        public string SiteStandardProfileRequestUrl { get; set; }

        /// <summary>
        /// Field: 'id' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Field: 'maiden-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "maiden-name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Field: 'formatted-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "formatted-name")]
        public string FormattedName { get; set; }

        /// <summary>
        /// Field: 'phonetic-first-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "phonetic-first-name")]
        public string PhoneticFirstName { get; set; }

        /// <summary>
        /// Field: 'phonetic-last-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "phonetic-last-name")]
        public string PhoneticLastName { get; set; }

        /// <summary>
        /// Field: 'formatted-phonetic-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "formatted-phonetic-name")]
        public string FormattedPhoneticName { get; set; }

        /// <summary>
        /// Field: 'location:(name)' (on-demand)
        /// Field: 'location:(country:(code))' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "location")]
        #warning Field is to be ignored or has issues
        public Location Location { get; set; }

        /// <summary>
        /// Field: 'industry' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "industry")]
        public string Industry { get; set; }

        /// <summary>
        /// Field: 'distance' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "distance")]
        public string Distance { get; set; }

        /// <summary>
        /// Field: 'relation-to-viewer:(distance)' (on-demand)
        /// Field: 'relation-to-viewer:(related-connections)' (on-demand)
        /// Field: 'relation-to-viewer:(connections)' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "relation-to-viewer")]
        #warning Field is to be ignored or has issues
        public RelationToViewer RelationToViewer { get; set; }

        /// <summary>
        /// Field: 'current-status' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "current-status")]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// Field: 'current-status-timestamp' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "current-status-timestamp")]
        public string CurrentStatusTimestamp { get; set; }

        /// <summary>
        /// Field: 'current-share' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "current-share")]
        public string CurrentShare { get; set; }

        /// <summary>
        /// Field: 'num-connections' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "num-connections")]
        public string NumConnections { get; set; }

        /// <summary>
        /// Field: 'num-connections-capped' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "num-connections-capped")]
        public string NumConnectionsCapped { get; set; }

        /// <summary>
        /// Field: 'summary' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Field: 'specialties' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "specialties")]
        public string Specialties { get; set; }

        /// <summary>
        /// Field: 'positions' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "positions")]
        public string Positions { get; set; }

        /// <summary>
        /// Field: 'picture-url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "picture-url")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// Field: 'site-standard-profile-request' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "site-standard-profile-request")]
        #warning Field is to be ignored or has issues
        public string SiteStandardProfileRequest { get; set; }

        /// <summary>
        /// Field: 'api-standard-profile-request:(url)' (on-demand)
        /// Field: 'api-standard-profile-request:(headers)' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "api-standard-profile-request")]
        #warning Field is to be ignored or has issues
        public ApiStandardProfileRequest ApiStandardProfileRequest { get; set; }

        /// <summary>
        /// Field: 'public-profile-url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "public-profile-url")]
        public string PublicProfileUrl { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'connections'
    /// </summary>
    [Serializable, XmlRoot("connections")]
    public class Connections
    {
        /// <summary>
        /// Field: 'person' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "person")]
        public List<string> Person { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'site-standard-profile-request'
    /// </summary>
    [Serializable, XmlRoot("site-standard-profile-request")]
    public class SiteStandardProfileRequest
    {
        /// <summary>
        /// Field: 'url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'location'
    /// </summary>
    [Serializable, XmlRoot("location")]
    public class Location
    {
        /// <summary>
        /// Field: 'name' (on-demand)
        /// Field: 'name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Field: 'country' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'country'
    /// </summary>
    [Serializable, XmlRoot("country")]
    public class Country
    {
        /// <summary>
        /// Field: 'code' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'relation-to-viewer'
    /// </summary>
    [Serializable, XmlRoot("relation-to-viewer")]
    public class RelationToViewer
    {
        /// <summary>
        /// Field: 'distance' (on-demand)
        /// Field: 'distance' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "distance")]
        public string Distance { get; set; }

        /// <summary>
        /// Field: 'related-connections' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "related-connections")]
        public string RelatedConnections { get; set; }

        /// <summary>
        /// Field: 'connections' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "connections")]
        public string Connections { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'api-standard-profile-request'
    /// </summary>
    [Serializable, XmlRoot("api-standard-profile-request")]
    public class ApiStandardProfileRequest
    {
        /// <summary>
        /// Field: 'url' (on-demand)
        /// Field: 'url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Field: 'headers' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "headers")]
        public string Headers { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Field selectors for the 'person', 'connections', 'site-standard-profile-request', 'location', 'country', 'relation-to-viewer', 'api-standard-profile-request' return types.
    /// </summary>
    public static class ProfilesFields {
        /// <summary>
        /// Includes the field 'first-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithFirstname(this FieldSelector<Person> me) { return me.Add("first-name"); }
        
        /// <summary>
        /// Includes the field 'last-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithLastname(this FieldSelector<Person> me) { return me.Add("last-name"); }
        
        /// <summary>
        /// Includes the field 'headline'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithHeadline(this FieldSelector<Person> me) { return me.Add("headline"); }
        
        /// <summary>
        /// Includes the field 'site-standard-profile-request/url'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithSiteStandardProfileRequestUrl(this FieldSelector<Person> me) { return me.Add("site-standard-profile-request/url"); }
        
        /// <summary>
        /// Includes the field 'id'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithId(this FieldSelector<Person> me) { return me.Add("id"); }
        
        /// <summary>
        /// Includes the field 'maiden-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithMaidenName(this FieldSelector<Person> me) { return me.Add("maiden-name"); }
        
        /// <summary>
        /// Includes the field 'formatted-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithFormattedName(this FieldSelector<Person> me) { return me.Add("formatted-name"); }
        
        /// <summary>
        /// Includes the field 'phonetic-first-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithPhoneticFirstName(this FieldSelector<Person> me) { return me.Add("phonetic-first-name"); }
        
        /// <summary>
        /// Includes the field 'phonetic-last-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithPhoneticLastName(this FieldSelector<Person> me) { return me.Add("phonetic-last-name"); }
        
        /// <summary>
        /// Includes the field 'formatted-phonetic-name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithFormattedPhoneticName(this FieldSelector<Person> me) { return me.Add("formatted-phonetic-name"); }
        
        #warning ReturnType 'person', Field 'location:(name)': unsupported syntax

        /// <summary>
        /// Includes the field 'industry'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithIndustry(this FieldSelector<Person> me) { return me.Add("industry"); }
        
        /// <summary>
        /// Includes the field 'distance'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithDistance(this FieldSelector<Person> me) { return me.Add("distance"); }
        
        #warning ReturnType 'person', Field 'relation-to-viewer:(distance)': unsupported syntax

        /// <summary>
        /// Includes the field 'current-status'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithCurrentStatus(this FieldSelector<Person> me) { return me.Add("current-status"); }
        
        /// <summary>
        /// Includes the field 'current-status-timestamp'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithCurrentStatusTimestamp(this FieldSelector<Person> me) { return me.Add("current-status-timestamp"); }
        
        /// <summary>
        /// Includes the field 'current-share'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithCurrentShare(this FieldSelector<Person> me) { return me.Add("current-share"); }
        
        /// <summary>
        /// Includes the field 'num-connections'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithNumConnections(this FieldSelector<Person> me) { return me.Add("num-connections"); }
        
        /// <summary>
        /// Includes the field 'num-connections-capped'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithNumConnectionsCapped(this FieldSelector<Person> me) { return me.Add("num-connections-capped"); }
        
        /// <summary>
        /// Includes the field 'summary'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithSummary(this FieldSelector<Person> me) { return me.Add("summary"); }
        
        /// <summary>
        /// Includes the field 'specialties'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithSpecialties(this FieldSelector<Person> me) { return me.Add("specialties"); }
        
        /// <summary>
        /// Includes the field 'positions'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithPositions(this FieldSelector<Person> me) { return me.Add("positions"); }
        
        /// <summary>
        /// Includes the field 'picture-url'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithPictureUrl(this FieldSelector<Person> me) { return me.Add("picture-url"); }
        
        /// <summary>
        /// Includes the field 'site-standard-profile-request'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithSiteStandardProfileRequest(this FieldSelector<Person> me) { return me.Add("site-standard-profile-request"); }
        
        #warning ReturnType 'person', Field 'api-standard-profile-request:(url)': unsupported syntax

        /// <summary>
        /// Includes the field 'public-profile-url'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithPublicProfileUrl(this FieldSelector<Person> me) { return me.Add("public-profile-url"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Person> WithAllFields(this FieldSelector<Person> me) { return me.AddRange("first-name", "last-name", "headline", "site-standard-profile-request/url", "id", "maiden-name", "formatted-name", "phonetic-first-name", "phonetic-last-name", "formatted-phonetic-name", "location:(name)", "industry", "distance", "relation-to-viewer:(distance)", "current-status", "current-status-timestamp", "current-share", "num-connections", "num-connections-capped", "summary", "specialties", "positions", "picture-url", "site-standard-profile-request", "api-standard-profile-request:(url)", "public-profile-url"); }
        
        /// <summary>
        /// Includes the field 'person'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Connections> WithPerson(this FieldSelector<Connections> me) { return me.Add("person"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Connections> WithAllFields(this FieldSelector<Connections> me) { return me.AddRange("person"); }
        
        /// <summary>
        /// Includes the field 'url'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<SiteStandardProfileRequest> WithUrl(this FieldSelector<SiteStandardProfileRequest> me) { return me.Add("url"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<SiteStandardProfileRequest> WithAllFields(this FieldSelector<SiteStandardProfileRequest> me) { return me.AddRange("url"); }
        
        /// <summary>
        /// Includes the field 'name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Location> WithName(this FieldSelector<Location> me) { return me.Add("name"); }
        
        /// <summary>
        /// Includes the field 'country'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Location> WithCountry(this FieldSelector<Location> me) { return me.Add("country"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Location> WithAllFields(this FieldSelector<Location> me) { return me.AddRange("name", "country"); }
        
        /// <summary>
        /// Includes the field 'code'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Country> WithCode(this FieldSelector<Country> me) { return me.Add("code"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Country> WithAllFields(this FieldSelector<Country> me) { return me.AddRange("code"); }
        
        /// <summary>
        /// Includes the field 'distance'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<RelationToViewer> WithDistance(this FieldSelector<RelationToViewer> me) { return me.Add("distance"); }
        
        /// <summary>
        /// Includes the field 'related-connections'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<RelationToViewer> WithRelatedConnections(this FieldSelector<RelationToViewer> me) { return me.Add("related-connections"); }
        
        /// <summary>
        /// Includes the field 'connections'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<RelationToViewer> WithConnections(this FieldSelector<RelationToViewer> me) { return me.Add("connections"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<RelationToViewer> WithAllFields(this FieldSelector<RelationToViewer> me) { return me.AddRange("distance", "related-connections", "connections"); }
        
        /// <summary>
        /// Includes the field 'url'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<ApiStandardProfileRequest> WithUrl(this FieldSelector<ApiStandardProfileRequest> me) { return me.Add("url"); }
        
        /// <summary>
        /// Includes the field 'headers'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<ApiStandardProfileRequest> WithHeaders(this FieldSelector<ApiStandardProfileRequest> me) { return me.Add("headers"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<ApiStandardProfileRequest> WithAllFields(this FieldSelector<ApiStandardProfileRequest> me) { return me.AddRange("url", "headers"); }
        
    }
}

namespace Sparkle.LinkedInNET.Companies
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'company'
    /// </summary>
    [Serializable, XmlRoot("company")]
    public class Company
    {
        /// <summary>
        /// Field: 'id' (default)
        /// </summary>
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Field: 'name' (default)
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Companies
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Field selectors for the 'company' return types.
    /// </summary>
    public static class CompaniesFields {
        /// <summary>
        /// Includes the field 'id'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Company> WithId(this FieldSelector<Company> me) { return me.Add("id"); }
        
        /// <summary>
        /// Includes the field 'name'.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Company> WithName(this FieldSelector<Company> me) { return me.Add("name"); }
        
        /// <summary>
        /// Includes all the fields.
        /// </summary>
        /// <param name="me">The field selector.</param>
        /// <returns>The field selector.</returns>
        public static FieldSelector<Company> WithAllFields(this FieldSelector<Company> me) { return me.AddRange("id", "name"); }
        
    }
}

namespace Sparkle.LinkedInNET.Groups
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Field selectors for the '' return types.
    /// </summary>
    public static class GroupsFields {
    }
}

namespace Sparkle.LinkedInNET.Jobs
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Field selectors for the '' return types.
    /// </summary>
    public static class JobsFields {
    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;

    /// <summary>
    /// Name: 'Profiles'
    /// </summary>
    public class ProfilesApi : BaseApi
    {
        internal ProfilesApi(LinkedInApi linkedInApi)
            : base(linkedInApi)
        {
        }
        
        /// <summary>
        /// the profile of the current user
        /// </summary>
        public Person GetMyProfile(
              UserAuthorization user
            , FieldSelector<Person> fields = null
        )
        {
            const string urlFormat = "/v1/people/~{FieldSelector}";
            var url = FormatUrl(urlFormat, fields);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Person>(context);
        }
        
        /// <summary>
        /// the profile of a user in the network
        /// </summary>
        public Person GetProfileById(
              UserAuthorization user
            , string memberToken
            , FieldSelector<Person> fields = null
        )
        {
            const string urlFormat = "/v1/people/id={MemberToken}{FieldSelector}";
            var url = FormatUrl(urlFormat, fields, "MemberToken", memberToken);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Person>(context);
        }
        
        /// <summary>
        /// the public profile of a user
        /// </summary>
        public Person GetPublicProfile(
              UserAuthorization user
            , string publicProfileUrl
            , FieldSelector<Person> fields = null
        )
        {
            const string urlFormat = "/v1/people/url={PublicProfileUrl}{FieldSelector}";
            var url = FormatUrl(urlFormat, fields, "PublicProfileUrl", publicProfileUrl);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Person>(context);
        }
        
        /// <summary>
        /// returns a list of 1st degree connections for a user 
        /// </summary>
        public Person GetMyConnections(
              UserAuthorization user
            , FieldSelector<Person> fields = null
        )
        {
            var url = "/v1/people/~/connections";

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Person>(context);
        }
        
        /// <summary>
        /// returns a list of 1st degree connections for a user 
        /// </summary>
        public Person GetConnectionsByProfileId(
              UserAuthorization user
            , string memberToken
            , FieldSelector<Person> fields = null
        )
        {
            const string urlFormat = "/v1/people/id={MemberToken}/connections";
            var url = FormatUrl(urlFormat, fields, "MemberToken", memberToken);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Person>(context);
        }
        
    }
}

namespace Sparkle.LinkedInNET.Companies
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;

    /// <summary>
    /// Name: 'Companies'
    /// </summary>
    public class CompaniesApi : BaseApi
    {
        internal CompaniesApi(LinkedInApi linkedInApi)
            : base(linkedInApi)
        {
        }
        
        /// <summary>
        /// Hacker Summary
        /// </summary>
        public Company GetList(
              UserAuthorization user
            , FieldSelector<Company> fields = null
        )
        {
            var url = "/v1/companies";

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Company>(context);
        }
        
        /// <summary>
        /// retrieve a company by using the company ID
        /// </summary>
        public Company GetById(
              UserAuthorization user
            , string companyId
            , FieldSelector<Company> fields = null
        )
        {
            const string urlFormat = "/v1/companies/{CompanyId}";
            var url = FormatUrl(urlFormat, fields, "CompanyId", companyId);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Company>(context);
        }
        
        /// <summary>
        /// Retrieve a company by universal-name.
        /// </summary>
        public Company GetByName(
              UserAuthorization user
            , string universalName
            , FieldSelector<Company> fields = null
        )
        {
            const string urlFormat = "/v1/companies/universal-name={UniversalName}";
            var url = FormatUrl(urlFormat, fields, "UniversalName", universalName);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Company>(context);
        }
        
        /// <summary>
        /// This returns an array of companies that match to the specified email domain.
        /// </summary>
        public Company GetListByEmailDomain(
              UserAuthorization user
            , string universalName
            , FieldSelector<Company> fields = null
        )
        {
            const string urlFormat = "/v1/companies/universal-name={UniversalName}";
            var url = FormatUrl(urlFormat, fields, "UniversalName", universalName);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            if (!this.ExecuteQuery(context))
                this.HandleXmlErrorResponse(context);
            return this.HandleXmlResponse<Company>(context);
        }
        
    }
}

namespace Sparkle.LinkedInNET.Groups
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;

    /// <summary>
    /// Name: 'Groups'
    /// </summary>
    public class GroupsApi : BaseApi
    {
        internal GroupsApi(LinkedInApi linkedInApi)
            : base(linkedInApi)
        {
        }
        
    }
}

namespace Sparkle.LinkedInNET.Jobs
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;

    /// <summary>
    /// Name: 'Jobs'
    /// </summary>
    public class JobsApi : BaseApi
    {
        internal JobsApi(LinkedInApi linkedInApi)
            : base(linkedInApi)
        {
        }
        
    }
}

namespace Sparkle.LinkedInNET
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;
    using Sparkle.LinkedInNET.Profiles;
    using Sparkle.LinkedInNET.Companies;
    using Sparkle.LinkedInNET.Groups;
    using Sparkle.LinkedInNET.Jobs;

    /// <summary>
    /// The factory for LinkedIn APIs.
    /// </summary>
    public partial class LinkedInApi : BaseApi
    {
        /// <summary>
        /// The Profiles API.
        /// </summary>
        public ProfilesApi Profiles{
            get { return new ProfilesApi(this); }
        }

        /// <summary>
        /// The Companies API.
        /// </summary>
        public CompaniesApi Companies{
            get { return new CompaniesApi(this); }
        }

        /// <summary>
        /// The Groups API.
        /// </summary>
        public GroupsApi Groups{
            get { return new GroupsApi(this); }
        }

        /// <summary>
        /// The Jobs API.
        /// </summary>
        public JobsApi Jobs{
            get { return new JobsApi(this); }
        }

    }
}


