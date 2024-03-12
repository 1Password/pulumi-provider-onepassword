// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Onepassword
{
    public static class GetItem
    {
        /// <summary>
        /// Use this data source to get details of an item by its vault uuid and either the title or the uuid of the item.
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Onepassword = Pulumi.Onepassword;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = Onepassword.GetItem.Invoke(new()
        ///     {
        ///         Vault = @var.Demo_vault,
        ///         Uuid = onepassword_item.Demo_sections.Uuid,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetItemResult> InvokeAsync(GetItemArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetItemResult>("onepassword:index/getItem:getItem", args ?? new GetItemArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to get details of an item by its vault uuid and either the title or the uuid of the item.
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Onepassword = Pulumi.Onepassword;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = Onepassword.GetItem.Invoke(new()
        ///     {
        ///         Vault = @var.Demo_vault,
        ///         Uuid = onepassword_item.Demo_sections.Uuid,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetItemResult> Invoke(GetItemInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetItemResult>("onepassword:index/getItem:getItem", args ?? new GetItemInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetItemArgs : global::Pulumi.InvokeArgs
    {
        [Input("noteValue")]
        private string? _noteValue;

        /// <summary>
        /// Secure Note value.
        /// </summary>
        public string? NoteValue
        {
            get => _noteValue;
            set => _noteValue = value;
        }

        /// <summary>
        /// The title of the item to retrieve. This field will be populated with the title of the item if the item it looked up by its UUID.
        /// </summary>
        [Input("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The UUID of the item to retrieve. This field will be populated with the UUID of the item if the item it looked up by its title.
        /// </summary>
        [Input("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// The UUID of the vault the item is in.
        /// </summary>
        [Input("vault", required: true)]
        public string Vault { get; set; } = null!;

        public GetItemArgs()
        {
        }
        public static new GetItemArgs Empty => new GetItemArgs();
    }

    public sealed class GetItemInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("noteValue")]
        private Input<string>? _noteValue;

        /// <summary>
        /// Secure Note value.
        /// </summary>
        public Input<string>? NoteValue
        {
            get => _noteValue;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _noteValue = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The title of the item to retrieve. This field will be populated with the title of the item if the item it looked up by its UUID.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// The UUID of the item to retrieve. This field will be populated with the UUID of the item if the item it looked up by its title.
        /// </summary>
        [Input("uuid")]
        public Input<string>? Uuid { get; set; }

        /// <summary>
        /// The UUID of the vault the item is in.
        /// </summary>
        [Input("vault", required: true)]
        public Input<string> Vault { get; set; } = null!;

        public GetItemInvokeArgs()
        {
        }
        public static new GetItemInvokeArgs Empty => new GetItemInvokeArgs();
    }


    [OutputType]
    public sealed class GetItemResult
    {
        /// <summary>
        /// The category of the item. One of ["login" "password" "database"]
        /// </summary>
        public readonly string Category;
        /// <summary>
        /// (Only applies to the database category) The name of the database.
        /// </summary>
        public readonly string Database;
        /// <summary>
        /// (Only applies to the database category) The address where the database can be found
        /// </summary>
        public readonly string Hostname;
        public readonly string Id;
        /// <summary>
        /// Secure Note value.
        /// </summary>
        public readonly string NoteValue;
        /// <summary>
        /// Password for this item.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// (Only applies to the database category) The port the database is listening on.
        /// </summary>
        public readonly string Port;
        /// <summary>
        /// A list of custom sections in an item
        /// </summary>
        public readonly ImmutableArray<Outputs.GetItemSectionResult> Sections;
        /// <summary>
        /// An array of strings of the tags assigned to the item.
        /// </summary>
        public readonly ImmutableArray<string> Tags;
        /// <summary>
        /// The title of the item to retrieve. This field will be populated with the title of the item if the item it looked up by its UUID.
        /// </summary>
        public readonly string Title;
        /// <summary>
        /// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The primary URL for the item.
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// Username for this item.
        /// </summary>
        public readonly string Username;
        /// <summary>
        /// The UUID of the item to retrieve. This field will be populated with the UUID of the item if the item it looked up by its title.
        /// </summary>
        public readonly string Uuid;
        /// <summary>
        /// The UUID of the vault the item is in.
        /// </summary>
        public readonly string Vault;

        [OutputConstructor]
        private GetItemResult(
            string category,

            string database,

            string hostname,

            string id,

            string noteValue,

            string password,

            string port,

            ImmutableArray<Outputs.GetItemSectionResult> sections,

            ImmutableArray<string> tags,

            string title,

            string type,

            string url,

            string username,

            string uuid,

            string vault)
        {
            Category = category;
            Database = database;
            Hostname = hostname;
            Id = id;
            NoteValue = noteValue;
            Password = password;
            Port = port;
            Sections = sections;
            Tags = tags;
            Title = title;
            Type = type;
            Url = url;
            Username = username;
            Uuid = uuid;
            Vault = vault;
        }
    }
}