
<template>

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExFrameworkUserPageController,} from "../controller";
@Options({
    name: "_Page_AdminFrameworkUserImport",  
    components: {
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

