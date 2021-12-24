
<template>
  <WtmGrid :PageController="PageController" :columnDefs="columnDefs" :gridOptions="gridOptions" />
</template>



<script lang="ts">
import { ColDef, ColGroupDef, GridOptions } from "ag-grid-community";
import { Inject, Options,Provide,Vue } from "vue-property-decorator";
import { MasterPageController,ExMasterPageController } from "../../controller";
import language from '@/client/locales/languagesys';
import RowAction from "./actionViewIndex.vue";
@Options({ components: {} })
export default class extends Vue {
  @Provide({ reactive: true }) readonly PageController = ExMasterPageController;
  get columnDefs(): (ColDef | ColGroupDef)[] {
    return [
      {
        headerName:'Page匯入編號',
        field: "Imp_lno",
      },
      {
        headerName:'Page客戶代號',
        field: "Vendorid",
      },
      {
        headerName:'Page料號',
        field: "Card_No",
      },
      {
        headerName:'Page客戶料號',
        field: "Cust_PartNo",
      },
      {
        headerName:'_AdminCreateTime',
        field: "CreateTime",
      },
      {
        headerName:'_AdminUpdateTime',
        field: "UpdateTime",
      },
      {
        headerName:'_AdminCreateBy',
        field: "CreateBy",
      },
      {
        headerName:'_AdminUpdateBy',
        field: "UpdateBy",
      },
      {
        headerName:'_AdminIsValid',
        field: "IsValid",
        cellRenderer: this.$FrameworkComponents.switch,
      },

    ]
  };
  get gridOptions(): GridOptions {
    return {
      frameworkComponents: {
        RowAction: this.__wtmToRowAction(RowAction, this.PageController),
      },
    };
  }
  created() { }
}
</script>

