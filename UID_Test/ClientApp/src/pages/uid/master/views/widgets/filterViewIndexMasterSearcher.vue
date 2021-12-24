

<template>
  <WtmFilter :PageController="PageController" @finish="onFinish" @reset="onReset">
    <WtmField entityKey="Imp_lno_Filter" />
    <WtmField entityKey="Vendorid_Filter" />
    <WtmField entityKey="Card_No_Filter" />
    <WtmField entityKey="Cust_PartNo_Filter" />
    <WtmField entityKey="CreateTime_Filter" />
    <WtmField entityKey="UpdateTime_Filter" />
    <WtmField entityKey="CreateBy_Filter" />
    <WtmField entityKey="UpdateBy_Filter" />
  </WtmFilter>
</template>



<script lang="ts">
import { Vue, Options, Provide, Inject } from "vue-property-decorator";
import { MasterPageController,ExMasterPageController,ExMasterEntity } from "../../controller";
import language from '@/client/locales/languagesys';
@Options({ components: {} })
export default class extends Vue {
  @Provide({ reactive: true }) readonly PageController = ExMasterPageController;
  @Provide({ reactive: true }) readonly PageEntity = ExMasterEntity;
  @Provide({ reactive: true }) readonly formState = { 
        Imp_lno: '',
        Vendorid: '',
        Card_No: '',
        Cust_PartNo: '',
        CreateTime: '',
        UpdateTime: '',
        CreateBy: '',
        UpdateBy: '', 
  };
  //readonly EnumLocaleLabel = EnumLocaleLabel;
  get Pagination() {
    return this.PageController.Pagination;
  }
  async onFinish(values) {
    await this.Pagination.onLoading(values);
  }
  async onReset(values) {
    await this.Pagination.onLoading(values);
  }
  mounted() { }
}
</script>

