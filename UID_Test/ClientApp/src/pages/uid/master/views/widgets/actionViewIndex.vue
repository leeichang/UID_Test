﻿

<template>
<div v-if="isRowAction">

    <a-button v-if="__wtmAuthority('update', PageController)" type='link' @click="toUID_Master_Edit()">
      <span><i18n-t :keypath="$locales.SysEdit" /></span>
    </a-button>
    <a-button v-if="__wtmAuthority('details', PageController)" type='link' @click="toUID_Master_Details()">
      <span><i18n-t :keypath="$locales.Page详情" /></span>
    </a-button>
    <WtmActionDelete :PageController="PageController" :params="params">
      <template #icon><span class="fa fa-trash" style='margin-right:5px'></span></template>
        <span><i18n-t :keypath="$locales.SysDelete" /></span>
    </WtmActionDelete>
</div>
<div v-else>

    <a-button v-if="__wtmAuthority('insert', PageController)" @click="toUID_Master_Create()">
      <template #icon><span class="fa fa-plus" style='margin-right:5px'></span></template>
      <span><i18n-t :keypath="$locales.SysCreate" /></span>
    </a-button>
    <WtmActionImport :PageController="PageController" :params="params">
      <template #icon><span class="fa fa-tasks" style='margin-right:5px'></span></template>
        <span><i18n-t :keypath="$locales.SysImport" /></span>
    </WtmActionImport>
    <WtmActionDelete :PageController="PageController" :params="params">
      <template #icon><span class="fa fa-trash" style='margin-right:5px'></span></template>
        <span><i18n-t :keypath="$locales.SysDelete" /></span>
    </WtmActionDelete>
    <a-button @click="toUID_Master_BatchEdit()">
      <template #icon><span class="fa fa-pencil-square" style='margin-right:5px'></span></template>
      <span><i18n-t :keypath="$locales.SysBatchEdit" /></span>
    </a-button>
    <WtmActionExport :PageController="PageController" :params="params">
      <template #icon><span class="fa fa-arrow-circle-down" style='margin-right:5px'></span></template>
        <span><i18n-t :keypath="$locales.SysExport" /></span>
    </WtmActionExport>
</div>
</template>



<script lang="ts">
import { Inject, Options, Provide, Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { MasterPageController,ExMasterPageController } from "../../controller";
@Options({ components: {} })
export default class extends Vue {
  // page Inject 注入 row 为 toRowAction 注入
  @Provide({ reactive: true }) readonly PageController = ExMasterPageController;
  get Pagination() {
    return this.PageController.Pagination;
  }
  /**
   * 行 操作 的参数 aggrid 传入
   * @type {ICellRendererParams}
   * @memberof Action
   */
  readonly params = {};
  /**
   * 行数据操作 有 aggrid 传入属性
   * @readonly
   * @memberof Action
   */
  get isRowAction() {
    return this.lodash.has(this.params, "node");
  }
  getRowData() {
    if (this.isRowAction) {
      return this.lodash.cloneDeep(this.lodash.get(this, "params.data", {}));
    }
    return this.lodash.cloneDeep(
      this.lodash.head(this.Pagination.selectionDataSource)
    );
  }
  
  toUID_Master_Create() {
    this.__wtmToDetails({
      uidmastercreate:''
    });
  }
  toUID_Master_Edit() {
    this.__wtmToDetails({
      uidmasteredit: this.lodash.get(
        this.getRowData(),
        this.PageController.key
      )
    });
  }
  toUID_Master_Details() {
    this.__wtmToDetails(
       this.lodash.assign(
         {
             uidmasterdetails: this.lodash.get(
                 this.getRowData(),
                 this.PageController.key
             )
         },
         { _readonly: '' }
        )
  );
  }
  toUID_Master_BatchEdit() {
    this.__wtmToDetails({
      uidmasterbatchedit: this.lodash.get(
        this.getRowData(),
        this.PageController.key
      )
    });
  }
  mounted() {}
}
</script>

