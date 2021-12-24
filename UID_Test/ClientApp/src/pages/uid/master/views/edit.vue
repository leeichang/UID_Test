
<template>
  <div>
    <FormViewEditEdit @refreshGrid="refreshGridMaster" />

  </div>

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExMasterPageController,} from "../controller";
import FormViewEditEdit from "./widgets/formViewEditEdit.vue";
@Options({
    name: "_PageUIDMasterEdit",  
    components: {
    FormViewEditEdit,
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

