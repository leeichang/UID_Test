
<template>
  <BatchFormViewBatchEdit />

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExFrameworkUserPageController,} from "../controller";
import BatchFormViewBatchEdit from "./widgets/batchFormViewBatchEdit.vue";
@Options({
    name: "_Page_AdminFrameworkUserBatchEdit",  
    components: {
    BatchFormViewBatchEdit
  },
})
export default class extends Vue {

    readonly ExFrameworkUserPageController = ExFrameworkUserPageController;

    

    
    created() {}
    mounted() {}
}
</script>
<style lang="less">
</style>

