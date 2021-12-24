
<template>
  <FormViewPasswordEdit @refreshGrid="refreshGridFrameworkUser" />

</template>


<script lang="ts">
import {Inject,mixins,Options,Provide,Vue } from "vue-property-decorator";
import {$locales} from "@/client";
import { ExFrameworkUserPageController,} from "../controller";
import FormViewPasswordEdit from "./widgets/formViewPasswordEdit.vue";
@Options({
    name: "_Page_AdminFrameworkUserPassword",  
    components: {
    FormViewPasswordEdit,
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

