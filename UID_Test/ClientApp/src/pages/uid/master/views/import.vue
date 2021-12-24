
<template>

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExMasterPageController,} from "../controller";
@Options({
    name: "_PageUIDMasterImport",  
    components: {
  },
})
export default class extends Vue {

    readonly ExMasterPageController = ExMasterPageController;

    

    
    created() {}
    mounted() {}
}
</script>
<style lang="less">
</style>

