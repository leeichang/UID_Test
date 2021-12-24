
<template>
  <FormViewEditEdit @refreshGrid="refreshGridFrameworkUser" />

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExFrameworkUserPageController,} from "../controller";
import FormViewEditEdit from "./widgets/formViewEditEdit.vue";
@Options({
    name: "_Page_AdminFrameworkUserEdit",  
    components: {
    FormViewEditEdit,
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

