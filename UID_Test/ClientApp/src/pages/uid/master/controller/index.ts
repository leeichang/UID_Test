

import * as WTM from "@/client";
export * from './entity';

export class MasterPageController extends WTM.ControllerBasics {
    constructor() {
        super()
        this.onReset({
            // 唯一标识
            key: "ID",
            // 搜索
            search: '/api/UID/Master/SearchMaster',
            // 详情
            details: '/api/UID/Master/{ID}',
            // 添加
            insert: '/api/UID/Master/Create',
            // 修改
            update: '/api/UID/Master/Edit',
            batchUpdate: { method: 'post', url: '/api/UID/Master/BatchEdit' },
            // 删除 单&多
            delete: '/api/UID/Master/BatchDelete',
            // 导入
            import: '/api/UID/Master/Import',
            // 导出
            export: '/api/UID/Master/MasterExportExcel',
            // 筛选导出
            exportIds: '/api/UID/Master/MasterExportExcelByIds',
            // 数据模板
            template: '/api/UID/Master/GetExcelTemplate'
        })
    }
}

export const ExMasterPageController = new MasterPageController()
