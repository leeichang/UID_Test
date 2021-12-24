
<template>
  <FilterViewIndexMasterSearcher />

  <ActionViewIndex />
  <a-divider />
  <GridViewIndex />


  <WtmView queryKey="uidmastercreate" :title="$i18n.t($locales.SysCreate)">
    <Create @refreshGrid="refreshGridMaster"/>
  </WtmView>

  <WtmView queryKey="uidmasteredit" :title="$i18n.t($locales.SysEdit)">
    <Edit @refreshGrid="refreshGridMaster"/>
  </WtmView>

  <WtmView queryKey="uidmasterdetails" :title="$i18n.t($locales.Page详情)">
    <Details @refreshGrid="refreshGridMaster"/>
  </WtmView>

  <WtmView queryKey="uidmasterimport" :title="$i18n.t($locales.SysImport)">
    <Import @refreshGrid="refreshGridMaster"/>
  </WtmView>

  <WtmView queryKey="uidmasterbatchedit" :title="$i18n.t($locales.SysBatchEdit)">
    <BatchEdit @refreshGrid="refreshGridMaster"/>
  </WtmView>
</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import {ExMasterPageController,} from "./controller";
import FilterViewIndexMasterSearcher from "./views/widgets/filterViewIndexMasterSearcher.vue";
import ActionViewIndex from "./views/widgets/actionViewIndex.vue";
import GridViewIndex from "./views/widgets/gridViewIndex.vue";
import Create from "@/pages/uid/master/views/create.vue";
import Edit from "@/pages/uid/master/views/edit.vue";
import Details from "@/pages/uid/master/views/details.vue";
import Import from "@/pages/uid/master/views/import.vue";
import BatchEdit from "@/pages/uid/master/views/batchEdit.vue";
@Options({
    name: "UID_Test.UID.Controllers,Master",  
    components: {
    FilterViewIndexMasterSearcher,
    ActionViewIndex,
    GridViewIndex,
    Create,
    Edit,
    Details,
    Import,
    BatchEdit,
  },
})
export default class extends Vue {

    readonly ExMasterPageController = ExMasterPageController;

    
    get queryKey() {
      return "uidmasterindex";
    }

    
    refreshGridMaster() {
        this.ExMasterPageController.Pagination.onCurrentChange({ current: 1 })
    }
    created() {}
    mounted() {}
}
</script>
<style lang="less">
</style>

