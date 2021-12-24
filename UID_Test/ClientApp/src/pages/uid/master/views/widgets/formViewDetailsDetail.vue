
<template>
  <WtmDetails :queryKey="queryKey" :loading="Entities.loading" :onFinish="onFinish">
    <a-row :gutter="6">
      <a-col :span="12">
         <WtmField entityKey="Imp_lnoDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="VendoridDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="Card_NoDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="Cust_PartNoDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="CreateTimeDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="UpdateTimeDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="CreateByDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="UpdateByDetail"/>
      </a-col>
      <a-col :span="12">
         <WtmField entityKey="IsValidDetail"/>
      </a-col>
    </a-row>

      <div>
        <WtmField entityKey="Detail_MasterDetail" :fieldProps="{ columnDefs:DetailMasterList2columnDefs,gridOptions:DetailMasterList2gridOptions }" />
      </div>

        <div style="text-align:right;">

        </div>

  <template #button>
  
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
    return "uidmasterdetails";
  }
  @Provide({ reactive: true }) formState = {
      Entity: {
        Imp_lno: '',
        Vendorid: '',
        Card_No: '',
        Cust_PartNo: '',
        CreateTime: undefined,
        UpdateTime: undefined,
        CreateBy: '',
        UpdateBy: '',
        IsValid: undefined,
        Detail_Master:[],
    },
  };
  
  
  async onLoading() {
      await this.Entities.onLoading({ ID: this.lodash.get(this.$route.query, this.queryKey) });
      this.formState = this.lodash.assign({}, this.formState, this.Entities.dataSource)
  }
  
  get DetailMasterList2columnDefs(): (ColDef | ColGroupDef)[] {
    return [
      { field: "Seq", headerName: "Page序號" },
      { field: "If_Repeated", headerName: "Page是否重複" },
      { field: "Repeate_No", headerName: "Page重複次數" },
      { field: "CreateTime", headerName: "_AdminCreateTime" },
      { field: "UpdateTime", headerName: "_AdminUpdateTime" },
      { field: "CreateBy", headerName: "_AdminCreateBy" },
      { field: "UpdateBy", headerName: "_AdminUpdateBy" },
    ];
  }

  get DetailMasterList2gridOptions(): GridOptions {
    return {};
  }
  
  created() {}
  mounted() {
    this.onLoading();
  }
}
</script>

