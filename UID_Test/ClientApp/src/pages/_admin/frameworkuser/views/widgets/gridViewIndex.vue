
<template>
  <WtmGrid :PageController="PageController" :columnDefs="columnDefs" :gridOptions="gridOptions" />
</template>



<script lang="ts">
import { ColDef, ColGroupDef, GridOptions } from "ag-grid-community";
import { Inject, Options,Provide,Vue } from "vue-property-decorator";
import { FrameworkUserPageController,ExFrameworkUserPageController } from "../../controller";
import language from '@/client/locales/languagesys';
import RowAction from "./actionViewIndex.vue";
@Options({ components: {} })
export default class extends Vue {
  @Provide({ reactive: true }) readonly PageController = ExFrameworkUserPageController;
  get columnDefs(): (ColDef | ColGroupDef)[] {
    return [
      {
        headerName:'SysAccount',
        field: "ITCode",
      },
      {
        headerName:'_AdminName',
        field: "Name",
      },
      {
        headerName:'_AdminGender',
        field: "Gender",
      },
      {
        headerName:'_AdminCellPhone',
        field: "CellPhone",
      },
      {
        headerName:'_AdminRole',
        field: "FrameworkRoleFrameworkUser_MT_WtmName_view",
      },
      {
        headerName:'_AdminGroup',
        field: "FrameworkGroupFrameworkUser_MT_WtmName_view",
      },
      {
        headerName:'_AdminIsValid',
        field: "IsValid",
        cellRenderer: this.$FrameworkComponents.switch,
      },
      {
        headerName:'_AdminPhoto',
        field: "PhotoId",
        cellRenderer: this.$FrameworkComponents.image,
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

