
<template>
  <FilterViewIndexFrameworkUserSearcher />

  <ActionViewIndex />
  <a-divider />
  <GridViewIndex />


  <WtmView queryKey="_adminframeworkusercreate" :title="$i18n.t($locales.SysCreate)">
    <Create @refreshGrid="refreshGridFrameworkUser"/>
  </WtmView>

  <WtmView queryKey="_adminframeworkuseredit" :title="$i18n.t($locales.SysEdit)">
    <Edit @refreshGrid="refreshGridFrameworkUser"/>
  </WtmView>

  <WtmView queryKey="_adminframeworkuserdetails" :title="$i18n.t($locales.Page详情)">
    <Details @refreshGrid="refreshGridFrameworkUser"/>
  </WtmView>

  <WtmView queryKey="_adminframeworkuserimport" :title="$i18n.t($locales.SysImport)">
    <Import @refreshGrid="refreshGridFrameworkUser"/>
  </WtmView>

  <WtmView queryKey="_adminframeworkuserbatchedit" :title="$i18n.t($locales.SysBatchEdit)">
    <BatchEdit @refreshGrid="refreshGridFrameworkUser"/>
  </WtmView>

  <WtmView queryKey="_adminframeworkuserpassword" :title="$i18n.t($locales.LoginChangePassword)">
    <Password @refreshGrid="refreshGridFrameworkUser"/>
  </WtmView>
</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import {ExFrameworkUserPageController,} from "./controller";
import FilterViewIndexFrameworkUserSearcher from "./views/widgets/filterViewIndexFrameworkUserSearcher.vue";
import ActionViewIndex from "./views/widgets/actionViewIndex.vue";
import GridViewIndex from "./views/widgets/gridViewIndex.vue";
import Create from "@/pages/_admin/frameworkuser/views/create.vue";
import Edit from "@/pages/_admin/frameworkuser/views/edit.vue";
import Details from "@/pages/_admin/frameworkuser/views/details.vue";
import Import from "@/pages/_admin/frameworkuser/views/import.vue";
import BatchEdit from "@/pages/_admin/frameworkuser/views/batchEdit.vue";
import Password from "@/pages/_admin/frameworkuser/views/password.vue";
@Options({
    name: "UID_Test._Admin.Controllers,FrameworkUser",  
    components: {
    FilterViewIndexFrameworkUserSearcher,
    ActionViewIndex,
    GridViewIndex,
    Create,
    Edit,
    Details,
    Import,
    BatchEdit,
    Password,
  },
})
export default class extends Vue {

    readonly ExFrameworkUserPageController = ExFrameworkUserPageController;

    
    get queryKey() {
      return "_adminframeworkuserindex";
    }

    
    refreshGridFrameworkUser() {
        this.ExFrameworkUserPageController.Pagination.onCurrentChange({ current: 1 })
    }
    created() {}
    mounted() {}
}
</script>
<style lang="less">
</style>

