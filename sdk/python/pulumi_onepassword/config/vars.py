# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

import types

__config__ = pulumi.Config('onepassword')


class _ExportableConfig(types.ModuleType):
    @property
    def account(self) -> Optional[str]:
        """
        A valid account's sign-in address or ID to use biometrics unlock. Can also be sourced from `OP_ACCOUNT` environment
        variable. Provider will use the 1Password CLI if set.
        """
        return __config__.get('account') or _utilities.get_env('OP_ACCOUNT')

    @property
    def op_cli_path(self) -> Optional[str]:
        """
        The path to the 1Password CLI binary. Can also be sourced from `OP_CLI_PATH` environment variable. Defaults to `op`.
        """
        return __config__.get('opCliPath') or _utilities.get_env('OP_CLI_PATH')

    @property
    def service_account_token(self) -> Optional[str]:
        """
        A valid 1Password service account token. Can also be sourced from `OP_SERVICE_ACCOUNT_TOKEN` environment variable.
        Provider will use the 1Password CLI if set.
        """
        return __config__.get('serviceAccountToken') or _utilities.get_env('OP_SERVICE_ACCOUNT_TOKEN')

    @property
    def token(self) -> Optional[str]:
        """
        A valid token for your 1Password Connect server. Can also be sourced from `OP_CONNECT_TOKEN` environment variable.
        Provider will use 1Password Connect server if set.
        """
        return __config__.get('token') or _utilities.get_env('OP_CONNECT_TOKEN')

    @property
    def url(self) -> Optional[str]:
        """
        The HTTP(S) URL where your 1Password Connect server can be found. Can also be sourced `OP_CONNECT_HOST` environment
        variable. Provider will use 1Password Connect server if set.
        """
        return __config__.get('url') or _utilities.get_env('OP_CONNECT_HOST')

