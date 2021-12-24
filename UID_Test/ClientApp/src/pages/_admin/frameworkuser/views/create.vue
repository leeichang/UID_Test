
<template>
  <FormViewCreateAdd @refreshGrid="refreshGridFrameworkUser" />

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExFrameworkUserPageController,} from "../controller";
import FormViewCreateAdd from "./widgets/formViewCreateAdd.vue";
@Options({
    name: "_Page_AdminFrameworkUserCreate",  
    components: {
    FormViewCreateAdd,
  },
})
export default class extends Vue {

    readonly ExFrameworkUserPageController = ExFrameworkUserPageController;

    

    
    refreshGridFrameworkUser() {
        this.$emit('refreshGrid');
    }
    created() {}
    mounted() {}
}
</script>
<style lang="less">
</style>

