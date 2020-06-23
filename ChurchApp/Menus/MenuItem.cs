using ChurchApp.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchApp.Menus
{
    public class MenuItem
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("post_author")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PostAuthor { get; set; }

        [JsonProperty("post_date")]
        public DateTimeOffset PostDate { get; set; }

        [JsonProperty("post_date_gmt")]
        public DateTimeOffset PostDateGmt { get; set; }

        [JsonProperty("post_content")]
        public string PostContent { get; set; }

        [JsonProperty("post_title")]
        public string PostTitle { get; set; }

        [JsonProperty("post_excerpt")]
        public string PostExcerpt { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }

        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }

        [JsonProperty("post_password")]
        public string PostPassword { get; set; }

        [JsonProperty("post_name")]
        public string PostName { get; set; }

        [JsonProperty("to_ping")]
        public string ToPing { get; set; }

        [JsonProperty("pinged")]
        public string Pinged { get; set; }

        [JsonProperty("post_modified")]
        public DateTimeOffset PostModified { get; set; }

        [JsonProperty("post_modified_gmt")]
        public DateTimeOffset PostModifiedGmt { get; set; }

        [JsonProperty("post_content_filtered")]
        public string PostContentFiltered { get; set; }

        [JsonProperty("post_parent")]
        public long PostParent { get; set; }

        [JsonProperty("guid")]
        public Uri Guid { get; set; }

        [JsonProperty("menu_order")]
        public long MenuOrder { get; set; }

        [JsonProperty("post_type")]
        public string PostType { get; set; }

        [JsonProperty("post_mime_type")]
        public string PostMimeType { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("db_id")]
        public long DbId { get; set; }

        [JsonProperty("menu_item_parent")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MenuItemParent { get; set; }

        [JsonProperty("object_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ObjectId { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_label")]
        public string TypeLabel { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("attr_title")]
        public string AttrTitle { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("classes")]
        public string[] Classes { get; set; }

        [JsonProperty("xfn")]
        public string Xfn { get; set; }

        [JsonProperty("child_items", NullValueHandling = NullValueHandling.Ignore)]
        public MenuItem[] ChildItems { get; set; }

        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }
    }

}
