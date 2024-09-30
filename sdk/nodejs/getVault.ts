// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Use this data source to get details of a vault by either its name or uuid.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as onepassword from "@pulumi/onepassword";
 *
 * const example = onepassword.getVault({
 *     name: "your-vault-name",
 * });
 * ```
 */
export function getVault(args?: GetVaultArgs, opts?: pulumi.InvokeOptions): Promise<GetVaultResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("onepassword:index/getVault:getVault", {
        "name": args.name,
        "uuid": args.uuid,
    }, opts);
}

/**
 * A collection of arguments for invoking getVault.
 */
export interface GetVaultArgs {
    /**
     * The name of the vault to retrieve. This field will be populated with the name of the vault if the vault it looked up by its UUID.
     */
    name?: string;
    /**
     * The UUID of the vault to retrieve. This field will be populated with the UUID of the vault if the vault it looked up by its name.
     */
    uuid?: string;
}

/**
 * A collection of values returned by getVault.
 */
export interface GetVaultResult {
    /**
     * The description of the vault.
     */
    readonly description: string;
    readonly id: string;
    /**
     * The name of the vault to retrieve. This field will be populated with the name of the vault if the vault it looked up by its UUID.
     */
    readonly name: string;
    /**
     * The UUID of the vault to retrieve. This field will be populated with the UUID of the vault if the vault it looked up by its name.
     */
    readonly uuid: string;
}
/**
 * Use this data source to get details of a vault by either its name or uuid.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as onepassword from "@pulumi/onepassword";
 *
 * const example = onepassword.getVault({
 *     name: "your-vault-name",
 * });
 * ```
 */
export function getVaultOutput(args?: GetVaultOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVaultResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("onepassword:index/getVault:getVault", {
        "name": args.name,
        "uuid": args.uuid,
    }, opts);
}

/**
 * A collection of arguments for invoking getVault.
 */
export interface GetVaultOutputArgs {
    /**
     * The name of the vault to retrieve. This field will be populated with the name of the vault if the vault it looked up by its UUID.
     */
    name?: pulumi.Input<string>;
    /**
     * The UUID of the vault to retrieve. This field will be populated with the UUID of the vault if the vault it looked up by its name.
     */
    uuid?: pulumi.Input<string>;
}
