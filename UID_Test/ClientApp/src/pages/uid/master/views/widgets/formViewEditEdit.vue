
<template>
  <WtmDetails :queryKey="queryKey" :loading="Entities.loading" :onFinish="onFinish">
    <a-row :gutter="6">
      <a-col :span="12">
         <WtmField entityKey="Imp_lnoEdit"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="VendoridEdit"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="Card_NoEdit"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="Cust_PartNoEdit"/>
      </a-col>
    </a-row>

      <div>
        <WtmField entityKey="Detail_MasterEdit" :fieldProps="{ columnDefs:DetailMasterList1columnDefs,gridOptions:DetailMasterList1gridOptions }" />
      </div>

        <div style="text-align:right;">


        </div>

  <template #button>
  
   <a-divider type="vertical" />
   <a-button type="primary" html-type="submit">
       <template v-slot:icon>
           <SaveOutlined style='margin-right:5px'/>
       </template>
       <i18n-t :keypath="$locales.SysSubmit" />
   </a-button>
   <a-divider type="vertical" />
   <a-button type="primary" @click.stop.prevent="__wtmBackDetails()">
       <template v-slot:icon>
           <RedoOutlined style='margin-right:5px'/>
       </template>
       <i18n-t :keypath="$locales.SysClose" />
   </a-button>
  </template>
  </WtmDetails>
</template>



<script lang="ts">
import { PageDetailsBasics } from "@/components";
import { Inject, mixins, Options, Provide } from "vue-property-decorator";
import { MasterPageController,ExMasterPageController,ExMasterEntity } from "../../controller";
import {$locales, $i18n} from "@/client";

import { ColDef, ColGroupDef, GridOptions } from "ag-grid-community";
@Options({ components: {} })
export default class extends mixins(PageDetailsBasics) {
  @Provide({ reactive: true }) readonly PageController = ExMasterPageController;
  @Provide({ reactive: true }) readonly PageEntity = ExMasterEntity;
  
  get queryKey() {
    return "uidmasteredit";
  }
  @Provide({ reactive: true }) formState = {
      Entity: {
        Imp_lno: '',
        Vendorid: '',
        Card_No: '',
        Cust_PartNo: '',
        Detail_Master:[],
    },
  };
  
  async onFinish(values) {
      await this.PageController.onUpdate(this.formState);
      await this.onRefreshGrid();
  }
  
  async onLoading() {
      await this.Entities.onLoading({ ID: this.lodash.get(this.$route.query, this.queryKey) });
      this.formState = this.lodash.assign({}, this.formState, this.Entities.dataSource)
  }
  
  get DetailMasterList1columnDefs(): (ColDef | ColGroupDef)[] {
    return [
      { field: "Seq", headerName: "Page序號" },
      { field: "If_Repeated", headerName: "Page是否重複" },
      { field: "Repeate_No", headerName: "Page重複次數" },
    ];
  }

  get DetailMasterList1gridOptions(): GridOptions {
    return {};
  }
  
  created() {}
  mounted() {
    this.onLoading();
  }
}
</script>

