
<template>
  <div>
    <FormViewCreateAdd @refreshGrid="refreshGridMaster" />

  </div>

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExMasterPageController,} from "../controller";
import FormViewCreateAdd from "./widgets/formViewCreateAdd.vue";
@Options({
    name: "_PageUIDMasterCreate",  
    components: {
    FormViewCreateAdd,
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

