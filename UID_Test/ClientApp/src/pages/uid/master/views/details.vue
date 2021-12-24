
<template>
  <div>
    <FormViewDetailsDetail @refreshGrid="refreshGridMaster" />

  </div>

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExMasterPageController,} from "../controller";
import FormViewDetailsDetail from "./widgets/formViewDetailsDetail.vue";
@Options({
    name: "_PageUIDMasterDetails",  
    components: {
    FormViewDetailsDetail,
  },
})
export default class extends Vue {

    readonly ExMasterPageController = ExMasterPageController;

    

    
    refreshGridMaster() {
        this.$emit('refreshGrid');
    }
    created() {}
    mounted() {}
}
</script>
<style lang="less">
</style>

