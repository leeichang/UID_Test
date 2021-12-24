


import { $i18n, WTM_EntitiesField, WTM_ValueType, FieldRequest, $locales } from '@/client';
import router from '@/router';
import { ColGroupDef, GridOptions } from 'ag-grid-community';
import { ColDef } from 'ag-grid-community';
import lodash from 'lodash';
import language from '@/client/locales/languagesys';

/**
 * 页面实体
 */

class MasterEntity {
    
    readonly Imp_lnoAdd: WTM_EntitiesField = {
        name: ['Entity', 'Imp_lno'],
        label: '_Model_Master_Imp_lno',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly VendoridAdd: WTM_EntitiesField = {
        name: ['Entity', 'Vendorid'],
        label: '_Model_Master_Vendorid',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly Card_NoAdd: WTM_EntitiesField = {
        name: ['Entity', 'Card_No'],
        label: '_Model_Master_Card_No',
        valueType: WTM_ValueType.text,
    }
    readonly Cust_PartNoAdd: WTM_EntitiesField = {
        name: ['Entity', 'Cust_PartNo'],
        label: '_Model_Master_Cust_PartNo',
        valueType: WTM_ValueType.text,
    }
    readonly Detail_MasterAdd: WTM_EntitiesField = {
        name: ['Entity', 'Detail_Master'],
        label: '_ModelDetail',
        valueType: WTM_ValueType.grid,
    }
    readonly Imp_lnoEdit: WTM_EntitiesField = {
        name: ['Entity', 'Imp_lno'],
        label: '_Model_Master_Imp_lno',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly VendoridEdit: WTM_EntitiesField = {
        name: ['Entity', 'Vendorid'],
        label: '_Model_Master_Vendorid',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly Card_NoEdit: WTM_EntitiesField = {
        name: ['Entity', 'Card_No'],
        label: '_Model_Master_Card_No',
        valueType: WTM_ValueType.text,
    }
    readonly Cust_PartNoEdit: WTM_EntitiesField = {
        name: ['Entity', 'Cust_PartNo'],
        label: '_Model_Master_Cust_PartNo',
        valueType: WTM_ValueType.text,
    }
    readonly Detail_MasterEdit: WTM_EntitiesField = {
        name: ['Entity', 'Detail_Master'],
        label: '_ModelDetail',
        valueType: WTM_ValueType.grid,
    }
    readonly Imp_lno_Filter : WTM_EntitiesField = {
        name: 'Imp_lno',
        label: '_Model_Master_Imp_lno',
        valueType: WTM_ValueType.text,
    }
    readonly Vendorid_Filter : WTM_EntitiesField = {
        name: 'Vendorid',
        label: '_Model_Master_Vendorid',
        valueType: WTM_ValueType.text,
    }
    readonly Card_No_Filter : WTM_EntitiesField = {
        name: 'Card_No',
        label: '_Model_Master_Card_No',
        valueType: WTM_ValueType.text,
    }
    readonly Cust_PartNo_Filter : WTM_EntitiesField = {
        name: 'Cust_PartNo',
        label: '_Model_Master_Cust_PartNo',
        valueType: WTM_ValueType.text,
    }
    readonly CreateTime_Filter : WTM_EntitiesField = {
        name: 'CreateTime',
        label: '_Model_Master_CreateTime',
        valueType: WTM_ValueType.dateRange,
    }
    readonly UpdateTime_Filter : WTM_EntitiesField = {
        name: 'UpdateTime',
        label: '_Model_Master_UpdateTime',
        valueType: WTM_ValueType.dateRange,
    }
    readonly CreateBy_Filter : WTM_EntitiesField = {
        name: 'CreateBy',
        label: '_Model_Master_CreateBy',
        valueType: WTM_ValueType.text,
    }
    readonly UpdateBy_Filter : WTM_EntitiesField = {
        name: 'UpdateBy',
        label: '_Model_Master_UpdateBy',
        valueType: WTM_ValueType.text,
    }
    readonly Imp_lnoDetail: WTM_EntitiesField = {
        name: ['Entity', 'Imp_lno'],
        label: '_Model_Master_Imp_lno',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly VendoridDetail: WTM_EntitiesField = {
        name: ['Entity', 'Vendorid'],
        label: '_Model_Master_Vendorid',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly Card_NoDetail: WTM_EntitiesField = {
        name: ['Entity', 'Card_No'],
        label: '_Model_Master_Card_No',
        valueType: WTM_ValueType.text,
    }
    readonly Cust_PartNoDetail: WTM_EntitiesField = {
        name: ['Entity', 'Cust_PartNo'],
        label: '_Model_Master_Cust_PartNo',
        valueType: WTM_ValueType.text,
    }
    readonly CreateTimeDetail: WTM_EntitiesField = {
        name: ['Entity', 'CreateTime'],
        label: '_Model_Master_CreateTime',
        valueType: WTM_ValueType.text,
    }
    readonly UpdateTimeDetail: WTM_EntitiesField = {
        name: ['Entity', 'UpdateTime'],
        label: '_Model_Master_UpdateTime',
        valueType: WTM_ValueType.text,
    }
    readonly CreateByDetail: WTM_EntitiesField = {
        name: ['Entity', 'CreateBy'],
        label: '_Model_Master_CreateBy',
        valueType: WTM_ValueType.text,
    }
    readonly UpdateByDetail: WTM_EntitiesField = {
        name: ['Entity', 'UpdateBy'],
        label: '_Model_Master_UpdateBy',
        valueType: WTM_ValueType.text,
    }
    readonly IsValidDetail: WTM_EntitiesField = {
        name: ['Entity', 'IsValid'],
        label: '_Model_Master_IsValid',
        rules:[{ required: true }],
        request: async (formState) => {
            return [
                { label: $i18n.t($locales.tips_bool_true), value: true },
                { label: $i18n.t($locales.tips_bool_false), value: false }
            ]
        },
        valueType: WTM_ValueType.text,
    }
    readonly Detail_MasterDetail: WTM_EntitiesField = {
        name: ['Entity', 'Detail_Master'],
        label: '_ModelDetail',
        valueType: WTM_ValueType.grid,
    }
    readonly LinkedVM_Imp_lno: WTM_EntitiesField = {
        name: ['LinkedVM', 'Imp_lno'],
        label: '_Model_Master_Imp_lno',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly LinkedVM_Vendorid: WTM_EntitiesField = {
        name: ['LinkedVM', 'Vendorid'],
        label: '_Model_Master_Vendorid',
        rules:[{ required: true }],
        valueType: WTM_ValueType.text,
    }
    readonly LinkedVM_Card_No: WTM_EntitiesField = {
        name: ['LinkedVM', 'Card_No'],
        label: '_Model_Master_Card_No',
        valueType: WTM_ValueType.text,
    }
    readonly LinkedVM_Cust_PartNo: WTM_EntitiesField = {
        name: ['LinkedVM', 'Cust_PartNo'],
        label: '_Model_Master_Cust_PartNo',
        valueType: WTM_ValueType.text,
    }
}

export const ExMasterEntity = new MasterEntity()

